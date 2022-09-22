using AIS_Lab.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.Controllers
{
    public class RightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddRight(Right right)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Rights.Add(right);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult DeleteRight(Right right)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Rights.Remove(right);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult ChangeRight(Right right)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Rights.Update(right);
                db.SaveChanges();
            }
            return View();
        }

        public List<Right> GetRight()
        {
            List<Right> rights = new List<Right>();
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                rights = db.Rights.ToList();
            }
            return rights;
        }
    }
}
