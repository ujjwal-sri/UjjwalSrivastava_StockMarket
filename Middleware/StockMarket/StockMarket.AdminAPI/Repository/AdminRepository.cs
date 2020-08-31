using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using StockMarket.AdminAPI.DBAccess;
using StockMarket.AdminAPI.Models;

namespace StockMarket.AdminAPI.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private AdminDBContext context;
        public AdminRepository(AdminDBContext context)
        {
            this.context = context;
        }
        public void AddCompany(Company item)
        {
            context.Companies.Add(item);
            context.SaveChanges();
        }

        public void DeleteCompany(string cid)
        {
            Company company = context.Companies.Find(cid);
            context.Companies.Remove(company);
            context.SaveChanges();
        }

        public List<Company> GetAllCompany()
        {
            return context.Companies.ToList();
        }

        public Company GetCompany(string Cid)
        {
            return context.Companies.Find(Cid);
        }

        public void UpdateCompany(Company item)
        {
            context.Companies.Update(item);
            context.SaveChanges();
        }
        public void AddIPO(IPO item)
        {
            IPO iipo = new IPO();
            context.Ipos.Add(item);
            context.Add(iipo);
            context.SaveChanges();
        }
        public void UpdateIPO(IPO item)
        {
            context.Ipos.Update(item);
            context.SaveChanges();
        }
    }
}
