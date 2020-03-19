using System.Threading.Tasks;
using CoV.DataAccess.Data;
using CoV.Service.Service;

namespace CoV.Service.Repository
{
    /// <summary>
      /// interface for UnitOfWork
      /// </summary>
      public interface IUnitOfWork
        {
            /// <summary>
            ///  Repository User
            /// </summary>
            IUserRepositoy UserRepository { get; }
            
            /// <summary>
            ///  Repository Studentt
            /// </summary>
            IStudentRepository StudentRepository { get; }
            
            /// <summary>
            ///  Repository Class
            /// </summary>
            IClassesRepository ClassRepository { get; }
            
            /// <summary>
            ///  Repository role
            /// </summary>
            IRoleRepository RoleRepository { get; }
            
            /// <summary>
            /// RePository Product 
            /// </summary>
            IProductRespository ProductRespository  { get; }
            
            /// <summary>
            ///  repository Color Product
            /// </summary>
            IColorProductRepository ColorProductRepository { get; }
            
            /// <summary>
            /// Repository Gender Repository
            /// </summary>
            IGenderRepository GenderRepository { get; }
            
            /// <summary>
            /// Repository Image
            /// </summary>
            IImageRepository ImageRepository { get; }
            
            /// <summary>
            /// Repository Size Product 
            /// </summary>
            IMakerProductRepository MakerProductRepository { get; }
            
            /// <summary>
            /// Repository Status Product 
            /// </summary>
            IStatusProductRepository StatusProductRepository { get; }
            
            /// <summary>
            /// Repository Product Category
            /// </summary>
            ICategoryProductRepository CategoryProductRepository { get; }
            
            /// <summary>
            ///  AppDbContext
            /// </summary>
            AppDbContext AppDbContext { get; }
            
            /// <summary>
            /// funtion Save 
            /// </summary>
            void Save();
         }
    
    /// <summary>
    /// Unit of work class
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Property for Unit of Word
        /// </summary>
        #region Properties
        private readonly AppDbContext _appDbContext;
        private UserRepositoy _userRepository;
        private StudentRepository _studentRepository;
        private ClassesRepository _classesRepository;
        private RoleRepository _roleRepository;
        private ProductRespository _productRespository;
        private CategoryProductRepository _categoryProductRepository;
        private ColorProductRepository _colorProductRepository;
        private GenderRepository _genderRepository;
        private ImageRepository _imageRepository;
        private MakerProductRepository _makerProductRepository;
        private StatusProductRepository _statusProductRepository;
        #endregion
        
        /// <summary>
        /// Unit Of Work Contructor
        /// </summary>
        /// <param name="tapDoorCloudDbContext"></param>
        public UnitOfWork(AppDbContext tapDoorCloudDbContext)
        {
            _appDbContext = tapDoorCloudDbContext;
        }

        #region Method
        /// <summary>
        /// Save
        /// </summary>
        public void Save()
        {
            _appDbContext.SaveChanges();
        }
        
        /// <summary>
        /// Save Async
        /// </summary>
        /// <returns></returns>
        public async Task SaveAsync()
        {
            await  _appDbContext.SaveChangesAsync();
        }
                
        /// <summary>
        /// Get AppDbContext
        /// </summary> 
        public AppDbContext AppDbContext => _appDbContext;
        public IUserRepositoy UserRepository
        {
            get
            {
                return _userRepository =
                    _userRepository ?? new UserRepositoy(_appDbContext);
            }
        }
        
        /// <summary>
        /// initalization studentReository
        /// </summary>
        public IStudentRepository StudentRepository
        {
            get
            {
                return _studentRepository =
                    _studentRepository ?? new StudentRepository(_appDbContext);
            }
        }
        
        /// <summary>
        /// initialization class repository
        /// </summary>
        public IClassesRepository ClassRepository
        {
            get { return _classesRepository = 
                _classesRepository ?? new ClassesRepository(_appDbContext); }
        }
        
        /// <summary>
        /// Initialization Role repository 
        /// </summary>
        public  IRoleRepository RoleRepository 
        {
            get {
                return _roleRepository = 
                _roleRepository ?? new RoleRepository(_appDbContext); 
            }
        }
        
        /// <summary>
        /// Initialization Product repository 7
        /// </summary>
        public  IProductRespository ProductRespository 
        {
            get {
                return _productRespository = 
                    _productRespository ?? new ProductRespository(_appDbContext);
            }
        }
        
        /// <summary>
        /// Initialization category  Product repository 6
        /// </summary>
        public  ICategoryProductRepository CategoryProductRepository 
        {
            get {
                return _categoryProductRepository = 
                    _categoryProductRepository ?? new CategoryProductRepository(_appDbContext);
            }
        }
        
        /// <summary>
        /// Initialization Color  Product repository 5
        /// </summary>
        public  IColorProductRepository ColorProductRepository 
        {
            get {
                return _colorProductRepository = 
                    _colorProductRepository ?? new ColorProductRepository(_appDbContext);
            }
        }
        
        /// <summary>
        /// Initialization gender  Product repository 4
        /// </summary>
        public  IGenderRepository GenderRepository 
        {
            get {
                return _genderRepository = 
                    _genderRepository ?? new GenderRepository(_appDbContext);
            }
        }
        
        /// <summary>
        /// Initialization Image  Product repository 3
        /// </summary>
        public  IImageRepository ImageRepository 
        {
            get {
                return _imageRepository = 
                    _imageRepository ?? new ImageRepository(_appDbContext);
            }
        }
        
        /// <summary>
        /// Initialization Size   Product repository 2
        /// </summary>
        public  IMakerProductRepository MakerProductRepository 
        {
            get {
                return _makerProductRepository = 
                    _makerProductRepository ?? new MakerProductRepository(_appDbContext);
            }
        }
        
        /// <summary>
        /// Initialization Size   Product repository 1
        /// </summary>
        public  IStatusProductRepository StatusProductRepository 
        {
            get {
                return _statusProductRepository = 
                    _statusProductRepository ?? new StatusProductRepository(_appDbContext);
            }
        }
        
        #endregion
        
    }
}