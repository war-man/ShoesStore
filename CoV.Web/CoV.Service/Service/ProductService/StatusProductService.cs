using System.Collections.Generic;
using AutoMapper;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Hosting;

namespace CoV.Service.Service
{
    public interface IStatusProductService
    {
        /// <summary>
        /// Get All Product View Model
        /// </summary>
        /// <returns></returns>
        IEnumerable<StatusProductViewModel> GetAll();
    }
    
    public class StatusProductService :IStatusProductService
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
        public StatusProductService(IUnitOfWork unitOfWork ,IMapper mapper ,IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        ///  funtion getall Status Product view model
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StatusProductViewModel> GetAll()
        {
            var statusProducts = _unitOfWork.StatusProductRepository.GetAll();
            var statusProductViewModels = _mapper.Map<IEnumerable<StatusProductViewModel>>(statusProducts);
            return statusProductViewModels;
        }
    }
}