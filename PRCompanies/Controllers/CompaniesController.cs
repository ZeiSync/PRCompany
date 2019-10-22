using Microsoft.AspNetCore.Mvc;
using PRCompanies.Models.Repository;
using PRCompanies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompanies.Controllers
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
            CompanyListViewModel companyListViewModel = new CompanyListViewModel();
            companyListViewModel.Companies = companyRepository.GetAll;
            return View(companyListViewModel);
        }

    }
}
