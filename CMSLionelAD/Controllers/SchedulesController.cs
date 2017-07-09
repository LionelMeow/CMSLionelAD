using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CMSLionelAD.Models;

namespace CMSLionelAD.Controllers
{
    [Authorize]
    public class SchedulesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Schedules
        public ActionResult Index()
        {
            var schedules = db.Schedules.Include(s => s.Container).Include(s => s.Employee).Include(s => s.Ship).Include(s => s.Shipyard).Include(s => s.Shipyard1);
            return View(schedules.ToList());
        }

        // GET: Schedules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule schedule = db.Schedules.Find(id);
            if (schedule == null)
            {
                return HttpNotFound();
            }
            return View(schedule);
        }

        // GET: Schedules/Create
        public ActionResult Create()
        {
            ViewBag.ContainerID = new SelectList(db.Containers, "ContainerID", "ContainerName");
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "EmployeeName");
            ViewBag.ShipID = new SelectList(db.Ships, "ShipID", "ShipName");
            ViewBag.DestinationShipyardID = new SelectList(db.Shipyards, "ShipyardID", "ShipYardName");
            ViewBag.ArrivalShipyardID = new SelectList(db.Shipyards, "ShipyardID", "ShipYardName");
            return View();
        }

        // POST: Schedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public ActionResult Create([Bind(Include = "ScheduleID,ShipID,ContainerID,ChargePrice,DepartureTime,ArrivalTime,DestinationShipyardID,ArrivalShipyardID,EmployeeID")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                db.Schedules.Add(schedule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContainerID = new SelectList(db.Containers, "ContainerID", "ContainerName", schedule.ContainerID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "EmployeeName", schedule.EmployeeID);
            ViewBag.ShipID = new SelectList(db.Ships, "ShipID", "ShipName", schedule.ShipID);
            ViewBag.DestinationShipyardID = new SelectList(db.Shipyards, "ShipyardID", "ShipYardName", schedule.DestinationShipyardID);
            ViewBag.ArrivalShipyardID = new SelectList(db.Shipyards, "ShipyardID", "ShipYardName", schedule.ArrivalShipyardID);
            return View(schedule);
        }

        // GET: Schedules/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule schedule = db.Schedules.Find(id);
            if (schedule == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContainerID = new SelectList(db.Containers, "ContainerID", "ContainerName", schedule.ContainerID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "EmployeeName", schedule.EmployeeID);
            ViewBag.ShipID = new SelectList(db.Ships, "ShipID", "ShipName", schedule.ShipID);
            ViewBag.DestinationShipyardID = new SelectList(db.Shipyards, "ShipyardID", "ShipYardName", schedule.DestinationShipyardID);
            ViewBag.ArrivalShipyardID = new SelectList(db.Shipyards, "ShipyardID", "ShipYardName", schedule.ArrivalShipyardID);
            return View(schedule);
        }

        // POST: Schedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public ActionResult Edit([Bind(Include = "ScheduleID,ShipID,ContainerID,ChargePrice,DepartureTime,ArrivalTime,DestinationShipyardID,ArrivalShipyardID,EmployeeID")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContainerID = new SelectList(db.Containers, "ContainerID", "ContainerName", schedule.ContainerID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeID", "EmployeeName", schedule.EmployeeID);
            ViewBag.ShipID = new SelectList(db.Ships, "ShipID", "ShipName", schedule.ShipID);
            ViewBag.DestinationShipyardID = new SelectList(db.Shipyards, "ShipyardID", "ShipYardName", schedule.DestinationShipyardID);
            ViewBag.ArrivalShipyardID = new SelectList(db.Shipyards, "ShipyardID", "ShipYardName", schedule.ArrivalShipyardID);
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule schedule = db.Schedules.Find(id);
            if (schedule == null)
            {
                return HttpNotFound();
            }
            return View(schedule);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        
        public ActionResult DeleteConfirmed(int id)
        {
            Schedule schedule = db.Schedules.Find(id);
            db.Schedules.Remove(schedule);
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
    }
}
