using System;
using Microsoft.AspNetCore.Mvc;

namespace WebSukaSuka.controllers
{
    public class HomeController : Controller  //meng-extend dari controllers
    {
        public IActionResult Index(){
            //return Content("Hello from Controller");
           //return View();                      // atau return View("nama_folder");
            return View("Views/Home/Index.cshtml"); 
        }
        public IActionResult About(){
            return View();                      
        }
    }
}