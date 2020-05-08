using System.Collections.Generic;
using AutoMapper;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Hosting;

namespace CoV.Service.Service
{
    public interface IColorProductService
    {
        /// <summary>
        /// GetAll Color Product 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ColorProductViewModel> GetAll();
    }
    public class ColorProductService : IColorProductService
    {
        #region  property
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnvironment;
        #endregion
        
        /// <summary>
        ///  ColorProductService Contructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public ColorProductService(IUnitOfWork unitOfWork ,IMapper mapper ,IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        ///  Funtion  GetAll Color Product 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ColorProductViewModel> GetAll()
        {
            var colorProducts = _unitOfWork.ColorProductRepository.GetAll();
            return _mapper.Map<IEnumerable<ColorProductViewModel>>(colorProducts);
        }
    }
}