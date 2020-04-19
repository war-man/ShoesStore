using System.Collections.Generic;
using AutoMapper;
using CoV.Service.DataModel;
using CoV.Service.Repository;

namespace CoV.Service.Service
{
    public interface ICartService
    {
        /// <summary>
        /// Show All Entity Cart 
        /// </summary>
        /// <returns></returns>
        IEnumerable<CartViewModel> GetAll();

        //CartViewModel Buy(int id);
    }

    public class CartService : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CartService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<CartViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<CartViewModel>>(_unitOfWork.CartRespository.GetAll()) ;
        }


      
    }
}