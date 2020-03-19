using System.Collections.Generic;
using AutoMapper;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Hosting;

namespace CoV.Service.Service
{
    public interface ISizeProductService
    {
        /// <summary>
        /// Get All SizeProduct
        /// </summary>
        IEnumerable<MakerProductViewModel> GetAll();
    }
    public class SizeProductService : ISizeProductService
    {
        #region  property
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnvironment;
        #endregion
        
        /// <summary>
        ///  SizeProductService Contructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public SizeProductService(IUnitOfWork unitOfWork ,IMapper mapper ,IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        /// funtion get all SizeProductViewModel and Mapper
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MakerProductViewModel> GetAll()
        {
            var makerProducts = _unitOfWork.MakerProductRepository.GetAll();
            var makerProductViewModels = _mapper.Map<IEnumerable<MakerProductViewModel>>(makerProducts);
            return makerProductViewModels;
        }
    }
}