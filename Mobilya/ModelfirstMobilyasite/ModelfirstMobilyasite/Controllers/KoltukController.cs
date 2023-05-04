using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelfirstMobilyasite.Models;

namespace ModelfirstMobilyasite.Controllers
{
    public class KoltukController : Controller
    {
        // GET: Koltuk
        Model1Container db = new Model1Container();
        public ActionResult Index()
        {
            return View(db.KoltukSet.ToList());
        }
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Koltuk save)
        {
           
                    db.KoltukSet.Add(save);
                    db.SaveChanges();
                    return RedirectToAction("Index"); 
        }
        public ActionResult Edit(int id)
        {
            
            
                return View(db.KoltukSet.Where(x => x.KoltukNo == id).FirstOrDefault());


            
        }
        [HttpPost]
        public ActionResult Edit(int id, Koltuk yenile)
        {
            
                db.Entry(yenile).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            
        }
        public ActionResult Delete(int id)
        {
           

                return View(db.KoltukSet.Where(x => x.KoltukNo == id).FirstOrDefault());


            
        }
        [HttpPost]
        public ActionResult Delete(int id, Koltuk Sil)
        {
            

                Sil = db.KoltukSet.Where(x => x.KoltukNo == id).FirstOrDefault();
                db.KoltukSet.Remove(Sil);
                db.SaveChanges();
                return RedirectToAction("Index");

            
        }
    }
}