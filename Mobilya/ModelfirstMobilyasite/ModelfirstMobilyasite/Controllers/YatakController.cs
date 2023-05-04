using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelfirstMobilyasite.Models;

namespace ModelfirstMobilyasite.Controllers
{
    public class YatakController : Controller
    {
        // GET: Yatak
        Model1Container db = new Model1Container();
        public ActionResult Index()
        {
            return View(db.YatakSet.ToList());
        }
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Yatak save)
        {

            db.YatakSet.Add(save);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {


            return View(db.YatakSet.Where(x => x.YatakNo == id).FirstOrDefault());



        }
        [HttpPost]
        public ActionResult Edit(int id, Yatak yenile)
        {

            db.Entry(yenile).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {


            return View(db.YatakSet.Where(x => x.YatakNo == id).FirstOrDefault());



        }
        [HttpPost]
        public ActionResult Delete(int id, Yatak Sil)
        {


            Sil = db.YatakSet.Where(x => x.YatakNo == id).FirstOrDefault();
            db.YatakSet.Remove(Sil);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}