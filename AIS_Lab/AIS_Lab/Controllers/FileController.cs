using AIS_Lab.Database;
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

        public IActionResult AddFile (File file)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Files.Add(file);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult DeleteFile(File file)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Files.Remove(file);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult ChangeFile(File file)
        {
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                db.Files.Update(file);
                db.SaveChanges();
            }
            return View();
        }

        public List<File> GetFiles()
        {
            List<File> files = new List<File>();
            using (ScientiaDBContext db = new ScientiaDBContext())
            {
                files = db.Files.ToList();
            }
            return files;
        }

    }
}
