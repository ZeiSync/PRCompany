using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRCompany.Models;
using PRCompany.ViewModel;
using PRCompany.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompany.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ICompanyRepository companyRepository;

        public CompaniesController(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public IActionResult Index()
        {
            CompanyListViewModel comanyListViewModel = new CompanyListViewModel();

            comanyListViewModel.Companies = companyRepository.GetAll.OrderBy(c => c.CompanyName);

            return View(comanyListViewModel);
        }

        //[Authorize]
        
        public IActionResult Create()
        {
            CompanyViewModel companyViewModel = new CompanyViewModel();
            return View(companyViewModel);
        }

        [HttpPost]
        public IActionResult Create(Company company)
        {
            return View();
        }
    }
}
