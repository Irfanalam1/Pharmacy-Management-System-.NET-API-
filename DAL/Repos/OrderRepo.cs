using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderRepo : Repo, IRepo<Order, int, bool>
    {
        public bool Create(Order obj)
        {
            db.Orders.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Create(Customer data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var order = Get(id);
            db.Orders.Remove(order);
            return db.SaveChanges() > 0;
        }

        public List<Order> Get()
        {
            return db.Orders.ToList();
        }

        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        public bool Update(Order obj)
        {
            var order = Get(obj.Id);
            db.Entry(order).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
