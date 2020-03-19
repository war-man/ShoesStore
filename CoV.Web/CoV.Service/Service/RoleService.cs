using System.Collections.Generic;
using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.EntityFrameworkCore;

namespace CoV.Service.Service
{
    public interface IRoleService
    {
        /// <summary>
        /// Get All Role Entity
        /// </summary>
        /// <returns></returns>
        IEnumerable<RoleViewModel> GetAll();
    }
    
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RoleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        /// <summary>
        /// Funtion Get All Role View , Map RoleViewModel 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RoleViewModel> GetAll()
        {
            var role = _unitOfWork.RoleRepository.GetAll();
            var roleViewModel = _mapper.Map<IEnumerable<RoleViewModel>>(role);
            return roleViewModel;
        }
    }
}