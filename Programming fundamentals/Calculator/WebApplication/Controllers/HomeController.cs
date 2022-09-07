using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
       
        [HttpGet]
        public IActionResult Numbers()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Numbers(int number)
        {
            ViewBag.NumbersRange = number;
            return View();
        }
        [HttpGet]
        public IActionResult Calculator()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Calculator(double firstNumber, string operation,double secondNumber)
        {
            string result = string.Empty;
            switch (operation)
            {
                case"+":
                    result = $"{firstNumber + secondNumber}";
                    break;
                case"-":
                    result = $"{firstNumber - secondNumber}";
                    break;
                case "*":
                    result = $"{firstNumber * secondNumber}";
                    break;
                case "/":
                    result = $"{firstNumber / secondNumber}";
                    break;
                default:
                    result = "Invalid operation";
                    break;
            }
           ViewBag.Result = result;
            
            return View();
        }
      
    }
}
