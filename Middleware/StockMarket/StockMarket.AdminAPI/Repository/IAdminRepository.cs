using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;

namespace StockMarket.AdminAPI.Repository
{
    public interface IAdminRepository
    {
        void AddCompany(Company item);
        void DeleteCompany(string cid);
        Company GetCompany(string Cid);
        void UpdateCompany(Company item);
        void AddIPO(IPO item);
        void UpdateIPO(IPO item);
        List<Company> GetAllCompany();

    }
}
