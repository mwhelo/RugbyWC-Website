using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project3.Context;
using Project3.Models;

namespace Project3.Controllers
{
    public class StatsController : Controller
    {
        private RugbyContext db = new RugbyContext();

        // GET: Stats
        public ActionResult Index()
        {
            var stats = db.Stats.Include(s => s.Player);
            return View(stats.ToList());
        }

        // GET: Stats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stat stat = db.Stats.Find(id);
            if (stat == null)
            {
                return HttpNotFound();
            }
            return View(stat);
        }

        // GET: Stats/Create
        public ActionResult Create()
        {
            ViewBag.PlayerId = new SelectList(db.Player, "PlayerId", "PlayerName");
            return View();
        }

        // POST: Stats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StatId,PlayerName,PlayerTeam,Appereances,Tires,Points,PlayerId")] Stat stat)
        {
            if (ModelState.IsValid)
            {
                db.Stats.Add(stat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlayerId = new SelectList(db.Player, "PlayerId", "PlayerName", stat.PlayerId);
            return View(stat);
        }

        // GET: Stats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stat stat = db.Stats.Find(id);
            if (stat == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlayerId = new SelectList(db.Player, "PlayerId", "PlayerName", stat.PlayerId);
            return View(stat);
        }

        // POST: Stats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StatId,PlayerName,PlayerTeam,Appereances,Tires,Points,PlayerId")] Stat stat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlayerId = new SelectList(db.Player, "PlayerId", "PlayerName", stat.PlayerId);
            return View(stat);
        }

        // GET: Stats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stat stat = db.Stats.Find(id);
            if (stat == null)
            {
                return HttpNotFound();
            }
            return View(stat);
        }

        // POST: Stats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stat stat = db.Stats.Find(id);
            db.Stats.Remove(stat);
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
