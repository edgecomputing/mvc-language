using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Translation.Models;



namespace Translation.Controllers
{
    public class TranslationController : Controller
    {
        //
        // GET: /Translation/

        public ActionResult Index()
        {
            //using (var db = new CATSEntities()) 
            //{
            //    return View(db.Translations);
            //}
            return View();
        }

        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        public ActionResult Create(Translation.Models.CATSEntities translation)
        {
            //try
            //{
            //    using (var db = new CATSEntities())
            //    {
            //        db.Translations.add(translation);
            //        db.SaveChanges();
            //    }
            //    return RedirectToAction("Index");
            //}
            //catch
            //{
                return View();
            //}
        }
       
        public ActionResult GetAll()
        {
            var db = new CATSEntities();
            Translation.Service.Translater converter = new Service.Translater();
            converter.GetForText("","");
            return View(db.Translations.ToList());
        }
    }
}
