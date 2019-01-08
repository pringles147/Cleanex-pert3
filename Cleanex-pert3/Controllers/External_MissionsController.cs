using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cleanex_pert3;

namespace Cleanex_pert3.Controllers
{
    public class External_MissionsController : Controller
    {
        private CleanDB1Entities db = new CleanDB1Entities();

        // GET: External_Missions
        public ActionResult Index()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int WeekNR = ciCurr.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            
            return View(db.External_Missions.ToList());
        }


        // GET: External_Missions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            External_Missions external_Missions = db.External_Missions.Find(id);
            if (external_Missions == null)
            {
                return HttpNotFound();
            }
            return View(external_Missions);
        }

        // GET: External_Missions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: External_Missions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExtEventID,ExtTitle,ExtDescription,ExtTools,ExtLocation,ExtAddress,ExtKeyNr,ExtFieldOfWork,ExtWeek")] External_Missions external_Missions)
        {
            if (ModelState.IsValid)
            {
                db.External_Missions.Add(external_Missions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(external_Missions);
        }

        // GET: External_Missions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            External_Missions external_Missions = db.External_Missions.Find(id);
            if (external_Missions == null)
            {
                return HttpNotFound();
            }
            return View(external_Missions);
        }

        // POST: External_Missions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExtEventID,ExtTitle,ExtDescription,ExtTools,ExtLocation,ExtAddress,ExtKeyNr,ExtFieldOfWork,ExtWeek")] External_Missions external_Missions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(external_Missions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(external_Missions);
        }

        // GET: External_Missions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            External_Missions external_Missions = db.External_Missions.Find(id);
            if (external_Missions == null)
            {
                return HttpNotFound();
            }
            return View(external_Missions);
        }

        // POST: External_Missions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            External_Missions external_Missions = db.External_Missions.Find(id);
            db.External_Missions.Remove(external_Missions);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public int GetWeekNumber()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int WeekNR = ciCurr.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return WeekNR;
        }



    }
}
