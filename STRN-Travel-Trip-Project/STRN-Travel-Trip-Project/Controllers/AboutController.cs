﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using STRN_Travel_Trip_Project.Models.Siniflar;

namespace STRN_Travel_Trip_Project.Controllers  /*Db den verileri çekmek için*/
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context(); /*Veritabanından çekilecek değerleri yazdığımız sayfayı yazıyoruz*/

        public ActionResult Index()
        {
            var degerler = c.Abouts.ToList();
            return View(degerler);
        }
    }
}