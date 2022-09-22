using AIS_Lab.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddApplication(Application application)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Applications.Add(application);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult DeleteApplication(Application application)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Applications.Remove(application);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult ChangeApplication(Application application)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Applications.Update(application);
                db.SaveChanges();
            }
            return View();
        }

        public List<Application> GetApplication()
        {
            List<Application> applications = new List<Application>();
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                applications = db.Applications.ToList();
            }
            return applications;
        }
    }
}
