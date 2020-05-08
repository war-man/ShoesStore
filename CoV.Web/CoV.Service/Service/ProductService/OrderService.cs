using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using AutoMapper;
using CoV.Common.Infrastructure;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.EntityFrameworkCore;

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

        OrderViewModel UpdateToShiper(int id);
        
        void Delete(int id) ;
    }

    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly IProductDetailsService _productDetailsService;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper, IProductService productService, IProductDetailsService productDetailsService)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
            _productDetailsService = productDetailsService;
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
            foreach (var item in cart)
            {
                var productdetails = _productDetailsService
                    .GetByProductColor(item.ProductId, item.Size);
                if (productdetails != null)
                {
                    productdetails.NumberProduct = productdetails.NumberProduct - item.Quantity;
                    _unitOfWork.ProductDetailsRespository.Update(_mapper.Map<ProductDetails>(productdetails));
                }
                _unitOfWork.Save();

            }
            foreach (var item in cart)
            {
                var order = new OrderViewModel
                {
                    Name = item.Name,
                    CreateDate = DateTime.Now,
                    Product = _productService.GetByIdCart(item.ProductId),
                    TotalPrice = item.TotalPrice + 30000,
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
            var order = _unitOfWork.OrderRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            return _mapper.Map<OrderViewModel>(order);
        }

        public OrderViewModel UpdateToShiper(int id)
        {
            var order =_unitOfWork.OrderRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            if (order != null)
            {
                order.StatusId = 5;
                _unitOfWork.OrderRespository.Update(order);
                _unitOfWork.Save();   
            }

            return _mapper.Map<OrderViewModel>(order);
        }

        public void Delete(int id)
        {
            var orDefault = _unitOfWork.OrderRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            _unitOfWork.OrderRespository.Delete(orDefault);
            _unitOfWork.Save();
        }

    }
}