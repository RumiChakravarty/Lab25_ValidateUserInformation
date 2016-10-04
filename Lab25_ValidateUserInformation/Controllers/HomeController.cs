using Lab25_ValidateUserInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab25_ValidateUserInformation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Index(Student students)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", students);
            }else
            {
                return View();
            }
        }

      
    }
}