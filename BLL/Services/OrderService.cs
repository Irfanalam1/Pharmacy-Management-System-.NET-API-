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
    public class OrderService
    {
        public static bool Create(OrderDTO ods)
        {
            var data = Convert(ods);
            return DataAccessFactory.OrderData().Create(data);
        }

        public static OrderDTO Get(int id)
        {
            return Convert(DataAccessFactory.OrderData().Get(id));
        }



        public static bool Update(OrderDTO ods)
        {
            var data = Convert(ods);
            return DataAccessFactory.OrderData().Update(data);
        }

        public static bool Delete(int id)
        {
            var order = DataAccessFactory.OrderData();
            return order.Delete(id);
        }

        public static List<OrderDTO> Get()
        {
            var data = DataAccessFactory.OrderData().Get();
            return Convert(data);
        }

        static List<OrderDTO> Convert(List<Order> ods)
        {
            var data = new List<OrderDTO>();
            foreach (Order i in ods)
            {
                data.Add(Convert(i));
            }
            return data;
        }

        static OrderDTO Convert(Order ods)
        {
            return new OrderDTO()
            {
                Id = ods.Id,
                Price = ods.Price,
                OrderedQuantity = ods.OrderedQuantity,
                Date = ods.Date,
            };
        }
        static Order Convert(OrderDTO ods)
        {
            return new Order()
            {
                Id = ods.Id,
                Price = ods.Price,
                OrderedQuantity = ods.OrderedQuantity,
                Date = ods.Date,
            };
        }
    }
}
