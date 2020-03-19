using System.Collections.Generic;
using AutoMapper;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Hosting;

namespace CoV.Service.Service
{
    public interface  IGenderService 
    {
        /// <summary>
        /// Show All Entity Student
        /// </summary>
        /// <returns></returns>
        IEnumerable<GenderViewModel> GetAll();
    }
    public class GenderService :IGenderService
    {
        #region  property
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnvironment;
        #endregion
        
        /// <summary>
        ///  GenderService Contructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public GenderService(IUnitOfWork unitOfWork ,IMapper mapper ,IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        /// funtion  get all Gerder 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GenderViewModel> GetAll()
        {
            var genders = _unitOfWork.GenderRepository.GetAll();
            var genderViewModels = _mapper.Map<IEnumerable<GenderViewModel>>(genders);
            return genderViewModels;
        }
    }
}