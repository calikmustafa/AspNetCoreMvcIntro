using AspNetCoreIntro.Entities;
using AspNetCoreIntro.Models;
using AspNetCoreIntro.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIntro.Controllers
{
    public class CustomerController:Controller
    {
        private ILogger _Logger;

        public CustomerController(ILogger logger)
        {
            _Logger = logger;
        }

        public IActionResult Index3()
        {
            _Logger.Log("dosyaya kaydedildi");
            List<Customer> customers = new List<Customer>
            {
                new Customer{ID=1,FirstName="Mustafa",LastName="Çalık",City="Gaziantep"},
                 new Customer{ID=2,FirstName="Zeynep",LastName="Çalık",City="Malatya"},
                  new Customer{ID=3,FirstName="Seher",LastName="Çalık",City="Gaziantep"},
                   new Customer{ID=4,FirstName="Hakan",LastName="Çalık",City="Malatya"}
            };
            List<string> shops = new List<string> { "Gaziantep", "Malatya", "İstanbul" };
            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops

            };
            return View(model);
        }
        [HttpGet]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel
            {
                Cities=new List<SelectListItem> 
                {
                    new SelectListItem
                    {
                            Text="Ankara",Value="06"
                    },
                    new SelectListItem
                    {
                            Text="İstanbul",Value="34"
                    },
                    new SelectListItem
                    {
                            Text="Malatya",Value="44"
                    }
                }
            });
        }

        [HttpPost]
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";
        }
    }
}
