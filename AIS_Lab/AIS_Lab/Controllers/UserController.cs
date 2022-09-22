using AIS_Lab.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddUser(User user)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult DeleteUser(User user)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult ChangeUser(User user)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Users.Update(user);
                db.SaveChanges();
            }
            return View();
        }

        public List<User> GetUser()
        {
            List<User> users = new List<User>();
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                users = db.Users.ToList();
            }
            return users;
        }
    }
}
