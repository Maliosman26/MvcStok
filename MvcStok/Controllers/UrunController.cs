﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        readonly MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var urunler = db.TBLURUNLER.ToList();
            return View(urunler);
        }
    }
}