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

namespace CoV.Service.Service
{
    public interface IProductService
    {
        /// <summary>
        /// Show All Entity Student
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductViewModel> GetAll();
        
        /// <summary>
        /// get product model by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ProductViewModel GetById(int id);
        ProductViewModel GetByIdCart(int id);

        
        /// <summary>
        /// Create And Update Product
        /// </summary>
        /// <param name="model"></param>
        void CreateOrUpdate(ProductViewModel model);
        
        /// <summary>
        /// Delete Product
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
        
        /// <summary>
        /// Get list Product  with female 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductViewModel> GetListShoesFemale();
        
        /// <summary>
        /// Get list Product  with male 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductViewModel> GetListShoesMale();
        
        /// <summary>
        /// Get list Product  with baby 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductViewModel> GetListShoesBaby();
        
        /// <summary>
        /// get list shoes sports
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductViewModel> GetListShoesSporst();
    }
     
    public class ProductService :IProductService
    {
         #region  property
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _hostingEnvironment;
        #endregion
        
        /// <summary>
        ///  ProduceService Contructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public ProductService(IUnitOfWork unitOfWork ,IMapper mapper ,IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        /// GetAll product
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProductViewModel> GetAll()
        {
            var products = _unitOfWork.ProductRespository.ObjectContext
                .Include(x => x.Gender)
                .Include(x => x.CategoryProduct)
                .Include(x =>x.MakerProduct)
               .ToList();//Entity 
            return  _mapper.Map<IEnumerable<ProductViewModel>>(products); // Return Model 
        }
        
        /// <summary>
        /// Funtion return model Product View model
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductViewModel GetById(int id)
        {
            var product = new ProductViewModel();
            product.CategoryProductViewModels = _unitOfWork.CategoryProductRepository.GetAll().Select(x => new CategoryProductViewModel()
            {
                CategoryName = x.CategoryName,
                Id = x.Id,
    
            }).ToList();
            
            product.GenderViewModels = _unitOfWork.GenderRepository.GetAll().Select(x => new GenderViewModel()
            {
                GenderName = x.GenderName,
                Id = x.Id,
    
            }).ToList();
            
            product.MakerProductViewModels = _unitOfWork.MakerProductRepository.GetAll().Select(x => new MakerProductViewModel()
            {
                MakerName = x.MakerName,
                Id = x.Id,
    
            }).ToList();
            
            if (id <= 0)
            {
                product.AvatarDetails = "5df170a5-e41b-473f-a8d2-4544f36db5f9_hinh-anh-hacker-anonymous_025627409.jpg";
                return product;
            }
            else
            {
                var productNew = _unitOfWork.ProductRespository.GetById(id);
                var productmodel = _mapper.Map<ProductViewModel>(productNew);
                productmodel.CategoryProductViewModels = product.CategoryProductViewModels;
                productmodel.GenderViewModels = product.GenderViewModels;
                productmodel.MakerProductViewModels = product.MakerProductViewModels;
                productmodel.PhotoPath = product.PhotoPath;
                return  productmodel ;
            }
        }

        public ProductViewModel GetByIdCart(int id)
        {
            var productNew = _unitOfWork.ProductRespository.GetById(id);
            return _mapper.Map<ProductViewModel>(productNew);
        }
        
        /// <summary>
        /// Funtion process Create and Update Product 
        /// </summary>
        /// <param name="model"></param>
        public void CreateOrUpdate(ProductViewModel model)
        {
            string uniqueFileName = null;
            if (model.PhotoPath != null)
            {
                string uploadsFoder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PhotoPath.FileName;
                string filePath = Path.Combine(uploadsFoder, uniqueFileName);
                model.PhotoPath.CopyTo(new FileStream(filePath, FileMode.Create));
                model.AvatarDetails = uniqueFileName;
            }
            var product = _mapper.Map<ProductViewModel, Product>(model);
            if (model.Id <= 0)
            {
                product.FirstDate= DateTime.Now;
//                product.PhotoPath = model.photoPath;
                _unitOfWork.ProductRespository.Add(product);
            }
            else
            {      
                _unitOfWork.ProductRespository.Update(product);
            }
            _unitOfWork.Save();
        }

        /// <summary>
        /// Delete Product a Entity
        /// </summary>
        /// <param name="id"></param>
         public void Delete(int id)
        {
            var product = _unitOfWork.ProductRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            _unitOfWork.ProductRespository.Delete(product);
            _unitOfWork.Save();
        }
        
        /// <summary>
        /// get all líst gerder famle
        /// </summary>
        /// <returns></returns>
        public  IEnumerable<ProductViewModel>  GetListShoesFemale()
        {
            var product =
                _unitOfWork.ProductRespository.ObjectContext.Where(x => x.Gender.GenderName.Equals(Constants.GenderProduct.Male) || 
                                                                        x.Gender.GenderName.Equals(Constants.GenderProduct.UnknownGender)).ToList();
            return  _mapper.Map<IEnumerable<ProductViewModel>>(product);
        }
        
        /// <summary>
        /// get all líst gerder female
        /// </summary>
        /// <returns></returns>
        public  IEnumerable<ProductViewModel>  GetListShoesMale()
        {
            var product =
                _unitOfWork.ProductRespository.ObjectContext.Where(x => x.Gender.GenderName.Equals(Constants.GenderProduct.Female) || 
                                                                        x.Gender.GenderName.Equals(Constants.GenderProduct.UnknownGender)).ToList();
            return  _mapper.Map<IEnumerable<ProductViewModel>>(product);
        }
        
        /// <summary>
        ///  get líst baby shoes
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProductViewModel> GetListShoesBaby()
        {
            var product =
                _unitOfWork.ProductRespository.ObjectContext.Where(x => x.Gender.GenderName.Equals(Constants.GenderProduct.Baby) || 
                                                                        x.Gender.GenderName.Equals(Constants.GenderProduct.UnknownGender)).ToList();
            return  _mapper.Map<IEnumerable<ProductViewModel>>(product);
        }

        /// <summary>
        /// get list shoes sprorst
        /// </summary>
        /// <returns></returns>
        public  IEnumerable<ProductViewModel> GetListShoesSporst()
        {
            var product =
                _unitOfWork.ProductRespository.ObjectContext.Where(x => x.CategoryProduct.CategoryName .Equals(Constants.CategoryProduct.Giaythethao)). ToList();
            return  _mapper.Map<IEnumerable<ProductViewModel>>(product);
        }

    }
}