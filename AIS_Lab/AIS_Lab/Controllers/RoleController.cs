using AIS_Lab.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIS_Lab.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddRole(Role role)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Roles.Add(role);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult DeleteRole(Role role)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Roles.Remove(role);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult ChangeRole(Role role)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Roles.Update(role);
                db.SaveChanges();
            }
            return View();
        }

        public List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                roles = db.Roles.ToList();
            }
            return roles;
        }
    }
}
