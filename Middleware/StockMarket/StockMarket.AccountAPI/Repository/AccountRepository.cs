using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.Models;
using StockMarket.AccountAPI.DBaccess;

namespace StockMarket.AccountAPI.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private StockDBContext context;
        public AccountRepository(StockDBContext context)
        {
            this.context = context;
        }
        public void AddUser(User item)
        {
            context.Users.Add(item);
            context.SaveChanges();
        }

        public void DeleteUser(string id)
        {
            User user = GetUserById(id);
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public User GetUserById(string id)
        {
           return context.Users.Find(id);
        }

        public void UpdateUser(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
        }

        public User Validate(string uname, string pwd)
        {
            User user = context.Users.SingleOrDefault(i => i.Username == uname && i.Password == pwd);
            return user;
        }
    }
}
