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
        InformationMEntities db = new InformationMEntities();
        public ActionResult Home()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Home(FormCollection form)
        {
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
            var Database = db.Students.ToList();
            return View(Database);
        }
        public ActionResult Delete(int? Id)
        {
             Student student = db.Students.Find(Id);
             db.Students.Remove(student);
             db.SaveChanges();
             return RedirectToAction("Home");
        }
        public ActionResult Edit(int? Id)
        {
            return View();
        }

    }
}