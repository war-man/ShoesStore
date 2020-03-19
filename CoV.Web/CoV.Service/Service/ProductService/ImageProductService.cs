using System.Collections.Generic;
using AutoMapper;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Hosting;

namespace CoV.Service.Service
{
    public interface IImageProductService
    {
        /// <summary>
        /// GetAll Image Produce View Model 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ImageProductViewModel> GetAll();
    }
    public class ImageProductService : IImageProductService
    {
        #region  property
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnvironment;
        #endregion
        
        /// <summary>
        ///  ImageProductService Contructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public ImageProductService(IUnitOfWork unitOfWork ,IMapper mapper ,IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        /// funtion get all image Product
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ImageProductViewModel> GetAll()
        {
            var images = _unitOfWork.ImageRepository.GetAll();
            var imageProductViewModels = _mapper.Map<IEnumerable<ImageProductViewModel>>(images);
            return imageProductViewModels;
        }
    }
}