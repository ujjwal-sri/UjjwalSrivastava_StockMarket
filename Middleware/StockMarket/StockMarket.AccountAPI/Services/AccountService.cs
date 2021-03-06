﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.Repository;
using StockMarket.AccountAPI.Models;

namespace StockMarket.AccountAPI.Services
{
    public class AccountService:IAccountService
    {
        private IAccountRepository accountRepository;
        public AccountService(IAccountRepository repo)
        {
            accountRepository = repo;
        }
        public void AddUser(User item)
        {
            accountRepository.AddUser(item);
        }
        public void DeleteUser(string id)
        {
            accountRepository.DeleteUser(id);
        }
        public User GetUserById(string id)
        {
            return accountRepository.GetUserById(id);
        }

        public void Update(User user)
        {
            accountRepository.UpdateUser(user);
        }

        public User Validate(string uname, string pwd)
        {
            return accountRepository.Validate(uname, pwd);
        }
    }
}
