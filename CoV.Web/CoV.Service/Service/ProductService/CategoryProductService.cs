using System.Collections.Generic;
using AutoMapper;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Hosting;


namespace CoV.Service.Service
{
    public interface ICategoryProductService
    {
        /// <summary>
        /// Show All Entity CategoryProduct
        /// </summary>
        /// <returns></returns>
        IEnumerable<CategoryProductViewModel> GetAll();
    }
    
    public class CategoryProductService : ICategoryProductService
    {
        #region  property
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnvironment;
        #endregion
        
        /// <summary>
        ///  CategoryProductService Contructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public CategoryProductService(IUnitOfWork unitOfWork ,IMapper mapper ,IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        /// funtion GetAll CategoryProductViewModel 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CategoryProductViewModel> GetAll()
        {
            var categorys = _unitOfWork.CategoryProductRepository.GetAll();
            var categoryProductViewModels = _mapper.Map<IEnumerable<CategoryProductViewModel>>(categorys);
            return categoryProductViewModels;
        }
    }
}