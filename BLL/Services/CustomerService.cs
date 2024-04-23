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
    public class CustomerService
    {
        public static bool Create(CustomerDTO prj)
        {
            var data = Convert(prj);
            return DataAccessFactory.CustomerData().Create(data);
        }

        public static CustomerDTO Get(int id)
        {
            return Convert(DataAccessFactory.CustomerData().Get(id));
        }



        public static bool Update(CustomerDTO obj)
        {
            var data = Convert(obj);
            return DataAccessFactory.CustomerData().Update(data);
        }

        public static bool Delete(int id)
        {
            var customer = DataAccessFactory.CustomerData();
            return customer.Delete(id);
        }

        public static List<CustomerDTO> Get()
        {
            var data = DataAccessFactory.CustomerData().Get();
            return Convert(data);
        }

        static List<CustomerDTO> Convert(List<Customer> prj)
        {
            var data = new List<CustomerDTO>();
            foreach (Customer i in prj)
            {
                data.Add(Convert(i));
            }
            return data;
        }

        static CustomerDTO Convert(Customer prj)
        {
            return new CustomerDTO()
            {
                Id = prj.Id,
                Uname = prj.Uname,
                Password = prj.Password,
                Name = prj.Name,
                Email = prj.Email,
                Phone = prj.Phone,
            };
        }
        static Customer Convert(CustomerDTO prj)
        {
            return new Customer()
            {
                Id = prj.Id,
                Uname = prj.Uname,
                Password = prj.Password,
                Name = prj.Name,
                Email = prj.Email,
                Phone = prj.Phone,
            };
        }

    }
}
