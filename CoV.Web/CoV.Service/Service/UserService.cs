using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using CoV.Common.Infrastructure;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace CoV.Service.Service
{
    /// <summary>
    /// interface for Userservice
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// funtion login with username and Password
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        User Login(LoginModel User);
        UserViewModel LoginForgetPassword(LoginForgetPassword model);
        
        /// <summary>
        /// Insert a Entity User
        /// </summary>
        /// <param name="user"></param>
        void CreateOrUpdate(UserViewModel model);
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<UserViewModel> Users();
        
        /// <summary>
        /// Get All User
        /// </summary>
        /// <returns></returns>
        IEnumerable<UserViewModel> GetAll();
        
        /// <summary>
        /// Delete a entity User by Id
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
        
        /// <summary>
        /// funtion get a User by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserViewModel GetbyId(int id);
        
        /// <summary>
        /// get by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        UserViewModel GetByName(string name);

    }
    public class UserService :IUserService
    {
        /// <summary>
        /// Property
        /// </summary>
        #region  property
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnvironment;
        #endregion
        
        /// <summary>
        ///  UserService Contructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public UserService(IUnitOfWork unitOfWork, IMapper mapper , IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        /// Check User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User Login(LoginModel user)
        {
            var account = _unitOfWork.UserRepository.ObjectContext.Include(s  => s.Role)
                .FirstOrDefault(s => s.UserName.Equals(user.Username)  && s.Password.Equals( user.Password));
            if (account== null)  
            {
                Log.Error(Constants.Document.AccountNotPound);
            }
            else
            {
                Log.Error(Constants.Document.AccountName + user.Username);
            }
            return account;
        }
        
        /// <summary>
        /// Check User
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserViewModel LoginForgetPassword(LoginForgetPassword model)
        {
            var account = _unitOfWork.UserRepository.ObjectContext.Include(s  => s.Role).AsNoTracking()
                .FirstOrDefault(s => s.UserName.Equals(model.Username)  && s.Password.Equals( model.Password));
            if (account== null)  
            {
                Log.Error(Constants.Document.AccountNotPound);
            }
            else
            {
                Log.Error(Constants.Document.AccountName + model.Username);
            }
            return _mapper.Map<UserViewModel>(account);
        }
   
        /// <summary>
        /// Create a User
        /// </summary>
        /// <param name="model"></param>
        public void CreateOrUpdate(UserViewModel model)
        {
            string uniqueFileName = null;
            if (model.PhotoPath != null)
            {
                string uploadsFoder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PhotoPath.FileName;
                string filePath = Path.Combine(uploadsFoder, uniqueFileName);
                model.PhotoPath.CopyTo(new FileStream(filePath, FileMode.Create));
                model.ImageAvatar = uniqueFileName;
            }
                if (model.Id > 0)
                {
                    var user = _mapper.Map<UserViewModel, User>(model);
                    _unitOfWork.UserRepository.Update(user);
                }
                else
                {
                    var user = _mapper.Map<UserViewModel, User>(model);
                    _unitOfWork.UserRepository.Add(user);
                }
                _unitOfWork.SaveAsync();            
        }

        /// <summary>
        /// Show Account
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserViewModel> Users()
        {
            var user = _unitOfWork.UserRepository.ObjectContext.Include(s => s.Role).ToList();
            var userViewModel = _mapper.Map<IEnumerable<UserViewModel>>(user);
            return userViewModel ;
        }
        
        /// <summary>
        /// GetAll User
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserViewModel> GetAll()
        {
            var user = _unitOfWork.UserRepository.GetAll();
            var UserViewModel1 = _mapper.Map<IEnumerable<UserViewModel>>(user);
            return UserViewModel1 ;
        }
        /// <summary>
        /// Delete a Account
        /// </summary>
        /// <param name="id"></param>
        public  void Delete(int id)
        {
               User user = _unitOfWork.UserRepository.GetById(id); 
             _unitOfWork.UserRepository.Delete(user);
              _unitOfWork.Save();          
        }
        
        /// <summary>
        /// GetbyID Account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>       
        public UserViewModel GetbyId(int id)
        {
            var user = _unitOfWork.UserRepository.GetById(id);
            return _mapper.Map<User,UserViewModel>(user);
        }
        
        /// <summary>
        /// funtion get by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public UserViewModel GetByName(string name)
        {
            var userModel = _unitOfWork.UserRepository.ObjectContext.FirstOrDefault(x => x.UserName == name);
            return _mapper.Map<UserViewModel>(userModel);
        }
    }
}