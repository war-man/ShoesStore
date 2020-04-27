using System.Collections.Generic;
using AutoMapper;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Hosting;

namespace CoV.Service.Service
{
    public interface IOrderStatusService
    {
        /// <summary>
        /// Get All Product View Model
        /// </summary>
        /// <returns></returns>
        IEnumerable<OrderStatusViewModel> GetAll();
        
        
    }
    public class OrderStatusService : IOrderStatusService
    {
        #region  property
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment  _hostingEnvironment;
        #endregion
        
        /// <summary>
        ///  StatusProductService Contructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public OrderStatusService(IUnitOfWork unitOfWork ,IMapper mapper ,IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        ///  funtion getall Status Product view model
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrderStatusViewModel> GetAll()
        {
            var orderStatus = _unitOfWork.OrderStatusRespository.GetAll();
            var orderStatusViewModels = _mapper.Map<IEnumerable<OrderStatusViewModel>>(orderStatus);
            return orderStatusViewModels;
        }
    }
}