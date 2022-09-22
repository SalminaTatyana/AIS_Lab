using AIS_Lab.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.Controllers
{
    public class UserRightsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddUserRight(UserRight userRight)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.UserRights.Add(userRight);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult DeleteUserRight(UserRight userRight)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.UserRights.Remove(userRight);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult ChangeUserRight(UserRight userRight)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.UserRights.Update(userRight);
                db.SaveChanges();
            }
            return View();
        }

        public List<UserRight> GetUserRight()
        {
            List<UserRight> userRights = new List<UserRight>();
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                userRights = db.UserRights.ToList();
            }
            return userRights;
        }
    }
}
