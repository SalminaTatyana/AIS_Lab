﻿using AIS_Lab.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add (File file)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Files.Add(file);
                db.SaveChanges();
            }
            return View();
        }
    }
}