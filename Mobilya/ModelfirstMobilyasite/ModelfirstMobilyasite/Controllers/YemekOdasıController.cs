using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelfirstMobilyasite.Models;

namespace ModelfirstMobilyasite.Controllers
{
    public class YemekOdasıController : Controller
    {
        // GET: YemekOdası
        Model1Container db = new Model1Container();
        public ActionResult Index()
        {
            return View(db.YemekOdasıSet.ToList());
        }
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(YemekOdası save)
        {

            db.YemekOdasıSet.Add(save);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {


            return View(db.YemekOdasıSet.Where(x => x.YemekOdaNo == id).FirstOrDefault());



        }
        [HttpPost]
        public ActionResult Edit(int id, YemekOdası yenile)
        {

            db.Entry(yenile).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {


            return View(db.YemekOdasıSet.Where(x => x.YemekOdaNo == id).FirstOrDefault());



        }
        [HttpPost]
        public ActionResult Delete(int id, YemekOdası Sil)
        {


            Sil = db.YemekOdasıSet.Where(x => x.YemekOdaNo == id).FirstOrDefault();
            db.YemekOdasıSet.Remove(Sil);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}