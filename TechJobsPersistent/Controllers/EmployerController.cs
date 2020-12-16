using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{

    public class EmployerController : Controller
    {
        private JobDbContext context;

        public EmployerController(JobDbContext jobDbContext)
        {
            context = jobDbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }

        public IActionResult Add()
        {
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();
            return View(addEmployerViewModel);
        }

        [HttpPost]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel theViewModel)
        {
            if (ModelState.IsValid)
            {
                List<Employer> existingEmployers = context.Employers
                    .Where(e => e.Name == theViewModel.Name)
                    .Where(e => e.Location == theViewModel.Location)
                    .ToList();

                if(existingEmployers.Count == 0)
                {
                    Employer theEmployer = new Employer
                    {
                        Name = theViewModel.Name,
                        Location = theViewModel.Location
                    };

                    context.Employers.Add(theEmployer);
                    context.SaveChanges();

                    return Redirect("/Employer");
                }
            }
            return View("Add", theViewModel);
        }

        public IActionResult About(int id)
        {
            Employer theEmployer = context.Employers.Find(id);

            return View(theEmployer);
        }
    }
}
