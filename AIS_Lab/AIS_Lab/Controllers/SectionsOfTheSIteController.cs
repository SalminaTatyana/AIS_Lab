using AIS_Lab.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.Controllers
{
    public class SectionsOfTheSIteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddSectionsOfTheSite(SectionsOfTheSite sectionsOfTheSites)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.SectionsOfTheSites.Add(sectionsOfTheSites);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult DeleteSectionsOfTheSite(SectionsOfTheSite sectionsOfTheSites)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.SectionsOfTheSites.Remove(sectionsOfTheSites);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult ChangeSectionsOfTheSite(SectionsOfTheSite sectionsOfTheSites)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.SectionsOfTheSites.Update(sectionsOfTheSites);
                db.SaveChanges();
            }
            return View();
        }

        public List<SectionsOfTheSite> GetSectionsOfTheSite()
        {
            List<SectionsOfTheSite> sectionsOfTheSites = new List<SectionsOfTheSite>();
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                sectionsOfTheSites = db.SectionsOfTheSites.ToList();
            }
            return sectionsOfTheSites;
        }
    }
}
