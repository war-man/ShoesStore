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
    public interface IProductDetailsService
    {
        /// <summary>
        /// Show All Entity Student
        /// </summary>
        /// <returns></returns>
        IEnumerable<ProductDetailsViewModel> GetAll();

        /// <summary>
        /// get product model by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ProductDetailsViewModel GetById(int id);
        IEnumerable<ProductDetailsViewModel> GetByIdCart(int id);
         ProductDetailsViewModel CheckProductDetails(int id, int size);


        /// <summary>
        /// Create And Update Product 
        /// Create And Update Product details
        /// </summary>
        /// <param name="model"></param>
        void CreateOrUpdate(ProductDetailsViewModel model);

        /// <summary>
        /// Create And Update Product details
        /// </summary>
        /// <param name="model"></param>
        void Add(ProductDetailsViewModel model);

        ProductDetailsViewModel GetByProductColor(int productId,int size);
        
        /// <summary>
        /// Delete Product
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }

    public class ProductDetailsService : IProductDetailsService
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
        public ProductDetailsService(IUnitOfWork unitOfWork, IMapper mapper, IHostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// GetAll product  Details
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProductDetailsViewModel> GetAll()
        {
            var products = _unitOfWork.ProductDetailsRespository.ObjectContext.Include(x => x.Product)
                .Include(x => x.StatusProduct)
               .ToList();
            return _mapper.Map<IEnumerable<ProductDetailsViewModel>>(products); // Return Model 
        }

        /// <summary>
        /// Create And Update Product details
        /// </summary>
        /// <param name="model"></param>
        public void CreateOrUpdate(ProductDetailsViewModel model)
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
            var product = _mapper.Map<ProductDetailsViewModel, ProductDetails>(model);
            if (model.Id <= 0)
            {
                product.PhotoPath = model.PhotoPath;
                _unitOfWork.ProductDetailsRespository.Add(product);
            }
            else
            {
                _unitOfWork.ProductDetailsRespository.Update(product);
            }
            _unitOfWork.Save();
        }

        public void Add(ProductDetailsViewModel model)
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
            else
            {
                model.AvatarDetails = "9c2e88b5-1da5-4a38-abf2-6ab8398713f1_adidas-yeezy-350-cream-white.jpg";
            }
            var product = _mapper.Map<ProductDetailsViewModel, ProductDetails>(model);
            product.PhotoPath = model.PhotoPath;
            _unitOfWork.ProductDetailsRespository.Add(product);
            _unitOfWork.Save();
        }

        /// <summary>
        /// GetById Product Detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductDetailsViewModel GetById(int id)
        {
            var productdetail =
                _unitOfWork.ProductDetailsRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            return _mapper.Map<ProductDetailsViewModel>(productdetail);
        }

        /// <summary>
        /// Delete Product a Entity
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var product = _unitOfWork.ProductDetailsRespository.ObjectContext.FirstOrDefault(x => x.Id.Equals(id));
            _unitOfWork.ProductDetailsRespository.Delete(product);
            _unitOfWork.Save();
        }
        
        /// <summary>
        ///  get by product color
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="colorId"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public ProductDetailsViewModel GetByProductColor(int productId , int size)
        {
            var productdetails = _unitOfWork.ProductDetailsRespository.ObjectContext.AsNoTracking()
                .FirstOrDefault(x => 
                    x.ProductId.Equals(productId) && 
                    x.SizeProduct.Equals(size));
            return _mapper.Map<ProductDetailsViewModel>(productdetails);
        }
        
        public IEnumerable<ProductDetailsViewModel> GetByIdCart(int id )
        {
            var productNew = _unitOfWork.ProductDetailsRespository.ObjectContext.Where(x =>x.ProductId.Equals(id));
            return _mapper.Map<List<ProductDetailsViewModel>>(productNew);
        }

        /// <summary>
        /// check product Details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductDetailsViewModel CheckProductDetails(int id, int size)
        {
            var product = _unitOfWork.ProductDetailsRespository.ObjectContext.FirstOrDefault(x =>x.Product.Id.Equals(id) && x.SizeProduct.Equals(size));
            return _mapper.Map<ProductDetailsViewModel>(product);
        }
    }
}