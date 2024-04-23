using BLL.DTOs;
using DAL;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CartService
    {
        public static bool Create(CartDTO crt)
        {
            var data = Convert(crt);
            return DataAccessFactory.CartData().Create(data);
        }

        public static CartDTO Get(int id)
        {
            return Convert(DataAccessFactory.CartData().Get(id));
        }



        public static bool Update(CartDTO obj)
        {
            var data = Convert(obj);
            return DataAccessFactory.CartData().Update(data);
        }

        public static bool Delete(int id)
        {
            var cart = DataAccessFactory.CartData();
            return cart.Delete(id);
        }

        public static List<CartDTO> Get()
        {
            var data = DataAccessFactory.CartData().Get();
            return Convert(data);
        }

        static List<CartDTO> Convert(List<Cart> crt)
        {
            var data = new List<CartDTO>();
            foreach (Cart i in crt)
            {
                data.Add(Convert(i));
            }
            return data;
        }

        static CartDTO Convert(Cart crt)
        {
            return new CartDTO()
            {
                Id = crt.Id,
                MedicineId = crt.MedicineId,
                Medicine = crt.Medicine,
            };
        }
        static Cart Convert(CartDTO crt)
        {
            return new Cart()
            {
                Id = crt.Id,
                MedicineId = crt.MedicineId,
                Medicine = crt.Medicine,
            };
        }
    }
}
