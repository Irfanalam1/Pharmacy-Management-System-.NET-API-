using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Customer, int, bool> CustomerData()
        {
            return new CustomerRepo();
        }

        public static IRepo<Medicine, int, bool> MedicineData() 
        {
            return new MedicineRepo();
        }

        public static IRepo<Cart, int, bool> CartData() 
        {  
            return new CartRepo(); 
        }

        public static IRepo<Order, int, bool> OrderData() 
        {
            return new OrderRepo();
        }

    }

    
}
