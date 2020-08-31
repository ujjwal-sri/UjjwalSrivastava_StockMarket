using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;
using StockMarket.AdminAPI.Repository;

namespace StockMarket.AdminAPI.Services
{
    public class AdminService : IAdminService
    {
        private IAdminRepository adminRepository;
        public AdminService(IAdminRepository repo)
        {
            adminRepository = repo;
        }
        public void AddCompany(Company item)
        {
            adminRepository.AddCompany(item);
        }

        public void AddIPO(IPO item)
        {
            adminRepository.AddIPO(item);
        }

        public void DeleteCompany(string item)
        {
            adminRepository.DeleteCompany(item);
        }

        public List<Company> GetAllCompany()
        {
            return adminRepository.GetAllCompany();
        }

        public Company GetCompany(string cid)
        {
            return adminRepository.GetCompany(cid);
        }

        public void UpdateCompany(Company item)
        {
            adminRepository.UpdateCompany(item);
        }

        public void UpdateIPO(IPO item)
        {
            adminRepository.UpdateIPO(item);
        }
    }
}
