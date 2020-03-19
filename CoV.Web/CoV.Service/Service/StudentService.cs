using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace CoV.Service.Service
{
    /// <summary>
    /// Interface for StudentService
    /// </summary>
    public interface IStudentService
    {   
        /// <summary>
        /// Show All Entity Student
        /// </summary>
        /// <returns></returns>
        IEnumerable<StudentViewModel> Students();
       
        /// <summary>
        /// Insert a Entity Student
        /// </summary>
        /// <param name="model"></param>
        void CreateOrUpdate(StudentViewModel model);
        
        /// <summary>
        /// Deleta a Entity Student by Id
        /// </summary>
        /// <param name="id"></param>
        void Delete(int Id );
        
        /// <summary>
        /// return a Entity Student by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        StudentViewModel GetById(int id);
    }

    /// <summary>
    /// StudentService
    /// </summary>
    public class StudentService : IStudentService
    {
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
        public StudentService(IUnitOfWork unitOfWork ,IMapper mapper ,IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        /// show
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StudentViewModel> Students()
        {
            var student = _unitOfWork.StudentRepository.ObjectContext.Include(s => s.Classes).ToList();
            var studentViewModel = _mapper.Map<IEnumerable<StudentViewModel>>(student);
            return studentViewModel;
        }
      
        /// <summary>
        /// insert entity student
        /// </summary>
        /// <param name="model"></param>
        public void CreateOrUpdate(StudentViewModel model)
        {
            string uniqueFileName = null;
            if (model.PhotoPath != null)
            {
                string uploadsFoder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PhotoPath.FileName;
                string filePath = Path.Combine(uploadsFoder, uniqueFileName);
                model.PhotoPath.CopyTo(new FileStream(filePath, FileMode.Create));
                model.StudentAvatar = uniqueFileName;

            }
            var student = _mapper.Map<StudentViewModel, Student>(model);
            if (model.Id <= 0)
            {
                _unitOfWork.StudentRepository.Add(student);
            }
            else
            {
                _unitOfWork.StudentRepository.Update(student);
            }
            _unitOfWork.Save();
        }
        
        /// <summary>
        /// Delete A Entity of Id 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int Id )
        {
            var student = _unitOfWork.StudentRepository.ObjectContext.FirstOrDefault(s => s.Id.Equals(Id));
            _unitOfWork.StudentRepository.Delete(student);
            _unitOfWork.Save();
        }
        
        /// <summary>
        ///  Return a Entity Student by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  StudentViewModel GetById(int id)
        {
            var student = _unitOfWork.StudentRepository.GetById(id);
            return _mapper.Map<StudentViewModel>(student);
        }

    }
}