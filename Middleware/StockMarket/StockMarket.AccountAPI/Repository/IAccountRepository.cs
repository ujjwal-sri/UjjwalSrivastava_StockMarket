﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.Models;

namespace StockMarket.AccountAPI.Repository
{
    public interface IAccountRepository
    {
        void AddUser(User item);
        User Validate(string uname, string pwd);
        void DeleteUser(string id);
        void UpdateUser(User user);
        User GetUserById(string id);
    }
}
