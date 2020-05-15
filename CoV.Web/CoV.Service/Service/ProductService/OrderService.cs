using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using AutoMapper;
using CoV.Common.Infrastructure;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace CoV.Service.Service
{
    public interface IOrderService
    {
        /// <summary>
        /// Get All Customer
        /// </summary>
        /// <returns>View  Order Model</returns>
        IEnumerable<OrderViewModel> GetAll();

        /// <summary>
        /// Create And Update Order
        /// </summary>
        /// <param name="model"></param>
        void CreateOrUpdate(List<CartViewModel> cart);
        
        /// <summary>
        /// getbyid 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        OrderViewModel getById(int id);
        
        OrderViewModel getByPhone(string Phone,DateTime creatDate);

        OrderViewModel UpdateToShiper(int id);
        
        OrderViewModel UpdateShipNhan(int id);
        
        void Delete(int id) ;

        IEnumerable<OrderViewModel> CheckPhoneAndDate(string phone, DateTime dateTime);
    }

    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly IProductDetailsService _productDetailsService;
        private readonly ICustomerService _customerService;
        private readonly IHostingEnvironment _hostingEnvironment;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper, IProductService productService, IProductDetailsService productDetailsService, IHostingEnvironment hostingEnvironment, ICustomerService customerService)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
            _productDetailsService = productDetailsService;
            _hostingEnvironment = hostingEnvironment;
            _customerService = customerService;
            _mapper = mapper;
        }

        /// <summary>
        /// Funtion GetAll Account Customer
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrderViewModel> GetAll()
        {
            var order = _unitOfWork.OrderRespository.ObjectContext.Include(x => x.StatusOrder).ToList();
            return _mapper.Map<IEnumerable<OrderViewModel>>(order);
            
        }

        public void CreateOrUpdate(List<CartViewModel> cart)
        {
            OrderDetailsViewModel orderDetailsViewModel = new OrderDetailsViewModel();
            foreach (var item in cart)
            {
                var customer =_customerService.GetAll().FirstOrDefault(x => x.PhoneNumber.Equals(item.Name));
                if (customer != null)
                {
                    orderDetailsViewModel.NameCustomer = customer.LastName;
                    orderDetailsViewModel.CreateDate = DateTime.Now;
                    orderDetailsViewModel.PhoneNumber = customer.PhoneNumber;
                    orderDetailsViewModel.NumberProduct += item.Quantity;
                    orderDetailsViewModel.NameProduct += item.Product.Name +"("+item.Quantity+"SP"+ ")"+" Size: "+ item.Size + " *** ";
                    orderDetailsViewModel.ProductId = item.ProductId;
                    orderDetailsViewModel.Size = item.Size;
                    orderDetailsViewModel.StatusId = 1;
                    orderDetailsViewModel.Address = customer.Address + " " + customer.City;
                    orderDetailsViewModel.TotalMoney += item.TotalPrice + 30000;
                }
            }
            _unitOfWork.OrderDetailsRespository.Add(_mapper.Map<OrderDetals>(orderDetailsViewModel));
            _unitOfWork.Save();
            
            foreach (var item in cart)
            {
                var order = new OrderViewModel
                {
                    Name = item.Name,
                    CreateDate = DateTime.Now,
                    Product = _productService.GetByIdCart(item.ProductId),
                    TotalPrice = item.TotalPrice,
                    Quantity = item.Quantity,
                    StatusId = 1,
                    Size = item.Size,
                };
                _unitOfWork.OrderRespository.Add(_mapper.Map<Order>(order));
            }
            _unitOfWork.Save();
        }
        
        /// <summary>
        /// get by id order
        /// </summary>
        /// <param name="id"></param>
        /// <returns>OrderViewModel </returns>
        public OrderViewModel getById(int id)
        {
            var order = _unitOfWork.OrderRespository.ObjectContext.AsNoTracking().FirstOrDefault(x => x.Id.Equals(id));
            return _mapper.Map<OrderViewModel>(order);
        }

        public OrderViewModel UpdateToShiper(int id)
        {
            var order =_unitOfWork.OrderRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            if (order != null)
            {
                var productdetails = _productDetailsService
                    .GetByProductColor(order.ProductId, order.Size);
                if (productdetails == null ||  productdetails.NumberProduct == order.Quantity)
                {
                    order.StatusId = 6 ;
                    _unitOfWork.OrderRespository.Update(order);
                }
                else
                {
                    order.StatusId = 5;
                    _unitOfWork.OrderRespository.Update(order);
                }
                _unitOfWork.Save();   
            }

            return _mapper.Map<OrderViewModel>(order);
        }
    
        /// <summary>
        /// get by phone and create
        /// </summary>
        /// <param name="Phone"></param>
        /// <param name="creatDate"></param>
        /// <returns></returns>
        public OrderViewModel getByPhone(string Phone, DateTime creatDate)
        {
            var orderDetails = _unitOfWork.OrderRespository.ObjectContext.AsNoTracking()
                .Where(x => x.Name.Equals(Phone) && x.CreateDate.Equals(creatDate));
            return _mapper.Map<OrderViewModel>(orderDetails);
        }
        
        public OrderViewModel UpdateShipNhan(int id)
        {
            var order =_unitOfWork.OrderRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            if (order != null)
            {
                order.StatusId = 4;
                _unitOfWork.OrderRespository.Update(order);
            }
            _unitOfWork.Save();
            return _mapper.Map<OrderViewModel>(order);
        }
        
        public void Delete(int id)
        {
            var orDefault = _unitOfWork.OrderRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            _unitOfWork.OrderRespository.Delete(orDefault);
            _unitOfWork.Save();
        }
        
        /// <summary>
        /// get list orderdetails
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public IEnumerable<OrderViewModel> CheckPhoneAndDate(string phone, DateTime dateTime)
        {
            var order = _unitOfWork.OrderRespository.GetAll()
                .Where(x => x.Name.Equals(phone) && x.CreateDate == dateTime);
            return _mapper.Map<IEnumerable<OrderViewModel>>(order);
        }
    }
}