﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        readonly MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var musteriler = db.TBLMUSTERILER.ToList();
            return View(musteriler);
        }
    }
}