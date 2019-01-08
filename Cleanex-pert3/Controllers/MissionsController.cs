using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Cleanex_pert3;

namespace Cleanex_pert3.Controllers
{
    public class MissionsController : Controller
    {
        private CleanDB1Entities db = new CleanDB1Entities();

        // GET: Missions
        public ActionResult Index()
        {
            return View(db.Missions.ToList());
        }

        // GET: Missions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Missions missions = db.Missions.Find(id);
            if (missions == null)
            {
                return HttpNotFound();
            }
            return View(missions);
        }

        // GET: Missions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Missions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MissionID,Title,Address,Longitude,Latitude,ParkingZone,FieldOfWork,Tools,JobDescription,KeyNr,StartTime,EndTime,Partner,Comments,IsFullDay,Extra1,Extra2")] Missions missions)
        {
            if (ModelState.IsValid)
            {
                db.Missions.Add(missions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(missions);
        }

        // GET: Missions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Missions missions = db.Missions.Find(id);
            if (missions == null)
            {
                return HttpNotFound();
            }
            return View(missions);
        }

        // POST: Missions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MissionID,Title,Address,Longitude,Latitude,ParkingZone,FieldOfWork,Tools,JobDescription,KeyNr,StartTime,EndTime,Partner,Comments,IsFullDay,Extra1,Extra2")] Missions missions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(missions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(missions);
        }

        // GET: Missions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Missions missions = db.Missions.Find(id);
            if (missions == null)
            {
                return HttpNotFound();
            }
            return View(missions);
        }

        // POST: Missions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Missions missions = db.Missions.Find(id);
            db.Missions.Remove(missions);
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



        public JsonResult GetEvents()
        {
            using (CleanDB1Entities dc = new CleanDB1Entities())
            {
                var events = dc.Missions.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        [HttpPost]
        public JsonResult SaveEvent(Missions e)
        {
            var status = false;
            using (CleanDB1Entities dc = new CleanDB1Entities())
            {
                if (e.MissionID > 0)
                {
                    // Uppdatera Eventsen
                    var v = dc.Missions.Where(a => a.MissionID == e.MissionID).FirstOrDefault();
                    if (v != null)
                    {
                        v.Title = e.Title;
                        v.StartTime = e.StartTime;
                        v.EndTime = e.EndTime;
                        v.JobDescription = e.JobDescription;
                        v.IsFullDay = e.IsFullDay;
                        v.FieldOfWork = e.FieldOfWork;
                        v.Partner = e.Partner;
                    }
                }




                else
                {
                    dc.Missions.Add(e);
                }
                dc.SaveChanges();
                status = true;
            }

            return new JsonResult { Data = new { status = status } };
        }

        [HttpPost]
        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;
            using (CleanDB1Entities dc = new CleanDB1Entities())
            {
                var v = dc.Missions.Where(a => a.MissionID == eventID ).FirstOrDefault();
                if (v != null)
                {
                    dc.Missions.Remove(v);
                    dc.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult { Data = new { status = status } };
        }

    }
}
