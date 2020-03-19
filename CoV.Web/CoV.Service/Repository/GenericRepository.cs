using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoV.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace CoV.Service.Repository
{
    /// <summary>
        /// Generic Repository  interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface IGenericRepository<T> where T : class
        {
            //Get all<T>
            //Get all entities of type T
            IEnumerable<T> GetAll();
            
            //Get an entity by id
            T GetById(int id, bool alowTracking = true);
            
            // Marks an entity as new
            void Add(T entity);
            
            //Marks an entity to be delete
            void Delete(T entity);
            
            //Marks  an entity as modified
            void Update(T entity);
            
            Task<IEnumerable<T>> GetAllAsync(bool AllowTracking = true);
            
            // Gets entities using delegate
            Task<T> GetByIdAsync(int id, bool allowTracking = true);
            IQueryable<T> ObjectContext { get; set; }
        }
        
        /// <summary>
        /// Genneric Repository
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class GenericRepository<T> : IGenericRepository<T> where T :class
        {
            #region Properties
            private readonly Type _type;
            private readonly AppDbContext _AppDbContext;
            private readonly DbSet<T>  _DbSet;
            #endregion 
            
            /// <summary>
            /// GenericRepository constructor
            /// </summary>
            /// <param name="AppDbContext"></param>
            public GenericRepository(AppDbContext AppDbContext)
            {
               _AppDbContext= AppDbContext;
                _DbSet = _AppDbContext.Set<T>();
                _type = typeof(T);          
                ObjectContext = _DbSet;
            }
            
            public IQueryable<T> ObjectContext { get; set; }
            //Getall entity T
            public IEnumerable<T> GetAll()
            {
                return _DbSet.ToList();
            }
        
            //get an entity T
            public T GetById(int id, bool AllowTracking = true)
            {
                return _DbSet.Find(id);
            }
        
            /// <summary>
            /// Add T entity
            /// </summary>
            /// <param name="entity"></param>
            public void Add(T entity)
            {             
                _DbSet.Add(entity);
            }
        
            /// <summary>
            /// Delete T entity
            /// </summary>
            /// <param name="entity"></param>
            public void Delete(T entity)
            {
                _DbSet.Remove(entity);
            }
                
            /// <summary>
            /// Update T Entity
            /// </summary>
            /// <param name="entity"></param>
            public void Update(T entity)
            {
//                _DbSet.Attach(entity);
//                _AppDbContext.Entry(entity).State = EntityState.Modified;
                _AppDbContext.Entry(entity).State = EntityState.Modified;
                _DbSet.Update(entity);

            }
        
            /// <summary>
            /// Get all entities by some condition
            /// </summary>
            /// <param name="AllowTracking"></param>
            /// <returns></returns>
            public async Task<IEnumerable<T>> GetAllAsync(bool AllowTracking = true)
            {
                var data = await _DbSet.ToListAsync();
                return data;         
            }
        
            /// <summary>
            /// get T entity by Id
            /// </summary>
            /// <param name="id"></param>
            /// <param name="AllowTracking"></param>
            /// <returns></returns>
            public async Task<T> GetByIdAsync(int id, bool AllowTracking = true)
            {
                var data = await _DbSet.FindAsync(id);
                return data;
            }
    }
}