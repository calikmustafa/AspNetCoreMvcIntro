using AspNetCoreIntro.Entities;
using AspNetCoreIntro.Extension;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIntro.Controllers
{
    public class SessionDemoController : Controller
    {
        //sessionlarda datayı tutarız ve sonradan lazım olduğunda o datayı okuruz
        public string Index()
        {
            Customer customer = new Customer { ID = 1, FirstName = "ZEYNEP", LastName = "Çalık", City = "Malatya" };
            HttpContext.Session.SetString("isim", "Mustafa");//BURDA DATAYI YAZDIRDIK
           

            //OBJE TÜRÜNDEKİ VERİYİ YAZDIRMA
           
            HttpContext.Session.SetObject("musteri", customer);
            return "session oluştu";
        }

        public string Index2()
        {
         //return HttpContext.Session.GetString("isim");//YUKARIDA VERDİĞİMİZ İSİM(MUSTAFAYI) DEĞERİNİ BİZE YAZDIRICAK
            //OBJEYİ OKUMA
             var customer=HttpContext.Session.GetObject<Customer>("musteri");
            return customer.City;

        }
    }
}
