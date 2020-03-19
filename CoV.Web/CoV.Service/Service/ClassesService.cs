using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;
using CoV.Service.Repository;

namespace CoV.Service.Service
{
    /// <summary>
    /// Interface of ClassService
    /// </summary>
    public interface IClassesService
    {     
        /// <summary>
        /// Get all entity Clases
        /// </summary>
        /// <returns>tolist</returns>
        IEnumerable<CreateClasserModel> GetAll();
        
        /// <summary>
        /// Insert a Entity Classes
        /// </summary>
        /// <param name="createrClasser"></param>
        void CreaterClass(CreateClasserModel createrClasser);
        
        /// <summary>
        /// Delete a Entity by Id
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
        
        /// <summary>
        /// return A Classes by id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CreateClasserModel GetById(int id);
        
        /// <summary>
        /// Update A entity Classes
        /// </summary>
        /// <param name="model"></param>
        void Update(CreateClasserModel model);
    }
    
    /// <summary>
    /// ClassService
    /// </summary>
    public class ClassesService : IClassesService
    {
        #region Property
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion
        
        /// <summary>
        /// Constructor ClasserService
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public ClassesService(IUnitOfWork unitOfWork ,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        /// <summary>
        /// Show All Classes 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CreateClasserModel> GetAll()
        {
            var Classesr =_unitOfWork.ClassRepository.GetAll();
            var ClassesViewModel = _mapper.Map<IEnumerable<CreateClasserModel>>(Classesr);
            return ClassesViewModel;
        }
        
        /// <summary>
        /// Insert a entity Classer
        /// </summary>
        /// <param name="model"></param>
        public void CreaterClass(CreateClasserModel model)
        {
            var classes = _mapper.Map<Classes>(model);
            _unitOfWork.ClassRepository.Add(classes);
            _unitOfWork.Save();
        }
        
        /// <summary>
        /// Delete A Entity of Id 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var classer = _unitOfWork.ClassRepository.ObjectContext.FirstOrDefault(s => s.Id.Equals(id));
            _unitOfWork.ClassRepository.Delete(classer);
            _unitOfWork.Save();
        }
        
        /// <summary>
        ///  search  classes entity for id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  CreateClasserModel GetById(int id)
        {
            var classer = _unitOfWork.ClassRepository.GetById(id);
            return _mapper.Map<Classes,CreateClasserModel>(classer);
        }
        
        /// <summary>
        /// Update a Entity Class
        /// </summary>
        /// <param name="model"></param>
        public void Update(CreateClasserModel model)
        {
            var classes = _mapper.Map<CreateClasserModel, Classes>(model);
            _unitOfWork.ClassRepository.Update(classes);
            _unitOfWork.Save();
        }
    }
}