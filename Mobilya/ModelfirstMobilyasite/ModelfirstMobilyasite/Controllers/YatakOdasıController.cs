using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelfirstMobilyasite.Models;

namespace ModelfirstMobilyasite.Controllers
{
    public class YatakOdasıController : Controller
    {
        // GET: YatakOdası
        Model1Container db = new Model1Container();
        public ActionResult Index()
        {
            return View(db.YatakOdasıSet.ToList());
        }
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(YatakOdası save)
        {

            db.YatakOdasıSet.Add(save);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {


            return View(db.YatakOdasıSet.Where(x => x.YatakOdaNo == id).FirstOrDefault());



        }
        [HttpPost]
        public ActionResult Edit(int id, YatakOdası yenile)
        {

            db.Entry(yenile).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {


            return View(db.YatakOdasıSet.Where(x => x.YatakOdaNo == id).FirstOrDefault());



        }
        [HttpPost]
        public ActionResult Delete(int id, YatakOdası Sil)
        {


            Sil = db.YatakOdasıSet.Where(x => x.YatakOdaNo == id).FirstOrDefault();
            db.YatakOdasıSet.Remove(Sil);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}