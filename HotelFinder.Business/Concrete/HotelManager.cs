using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelservice
    {
        //private IHotelRepository _hotelRepository;

        //public HotelManager(IHotelRepository hotelRepository)
        //{
        //    _hotelRepository = hotelRepository;
        //}



        /*IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }*/

        ////////////////////////////////////

        private IHotelRepository _hotelRepository;

        public HotelManager()
        {
            _hotelRepository = new HotelRepository();
        }






        public Hotel CreateHotel(Hotel hotel)
      {
          return _hotelRepository.CreateHotel(hotel);
      }

      public void DeleteHotel(int id)
      {
          _hotelRepository.DeleteHotel(id);
      }

      public List<Hotel> GetAllHotels()
      {

          return _hotelRepository.GetAllHotels();
      }

      public Hotel GetHotelById(int id)
      {
          if (id > 0)
          {
              return _hotelRepository.GetHotelById(id);
          }
          throw new Exception("Id can not be less than 1");

      }

      public Hotel UpdateHotel(Hotel hotel)
      {
          return _hotelRepository.UpdateHotel(hotel);
      }
  }
}
