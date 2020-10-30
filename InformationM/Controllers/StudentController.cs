using InformationM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InformationM.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Home(FormCollection form)
        {
            InformationMEntities db = new InformationMEntities();
            Student Model = new Student();
            Model.Name = form["name"].Trim();
            Model.SurName = form["SurName"].Trim();
            Model.School = form["School"].Trim();
            db.Students.Add(Model);
            db.SaveChanges();
            return View(); 
        }
        public ActionResult DatabaseChange()
        {
            InformationMEntities db = new InformationMEntities();
            var Database = db.Students.ToList();
            return View(Database);
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }

    }
}