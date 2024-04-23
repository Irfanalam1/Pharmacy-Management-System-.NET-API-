using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CartRepo : Repo, IRepo<Cart, int, bool>
    {

        public bool Create(Cart crt)
        {
            db.Carts.Add(crt);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var cart = Get(id);
            db.Carts.Remove(cart);
            return db.SaveChanges() > 0;
        }

        public List<Cart> Get()
        {
            return db.Carts.ToList();
        }

        public Cart Get(int id)
        {
            return db.Carts.Find(id);
        }

        public bool Update(Cart crt)
        {
            var cart = Get(crt.Id);
            db.Entry(crt).CurrentValues.SetValues(crt);
            return db.SaveChanges() > 0;
        }

        bool IRepo<Cart, int, bool>.Create(Customer data)
        {
            throw new NotImplementedException();
        }
    }
}
