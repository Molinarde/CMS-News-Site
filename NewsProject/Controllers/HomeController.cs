using Microsoft.AspNetCore.Mvc;
using NewsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Controllers
{
    public class HomeController : Controller
    {
        IRepository repository;
        public HomeController(IRepository repository)
        {
            this.repository = repository;

        }


        public ViewResult List(string category)
        {
            var view = repository.News()
                 .Where(p => category == null || p.Category == category);
            return View(view);
        }
    }
}
