using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;

namespace StockMarket.AdminAPI.Services
{
    public interface IAdminService
    {
        void AddCompany(Company item);
        void DeleteCompany(string cid);
        Company GetCompany(string cid);
        void UpdateCompany(Company item);
        void AddIPO(IPO item);
        void UpdateIPO(IPO item);
        List<Company> GetAllCompany();
    }
}
