using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using newSmartEvent.Models;

namespace newSmartEvent.Controllers
{
    public class ParticipantsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Participants
        public ActionResult Index()
        {
            return View(db.Participants.ToList());
        }

        // GET: Participants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participants participants = db.Participants.Find(id);
            if (participants == null)
            {
                return HttpNotFound();
            }
            return View(participants);
        }

        // GET: Participants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Participants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ParticipantID,Part_Name,Part_Email,Part_ID,Part_No")] Participants participants)
        {
            if (ModelState.IsValid)
            {
                participants.Part_Email = User.Identity.GetUserId();
                db.Participants.Add(participants);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(participants);
        }

        // GET: Participants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participants participants = db.Participants.Find(id);
            if (participants == null)
            {
                return HttpNotFound();
            }
            return View(participants);
        }

        // POST: Participants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ParticipantID,Part_Name,Part_Email,Part_ID,Part_No")] Participants participants)
        {
            if (ModelState.IsValid)
            {
                db.Entry(participants).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(participants);
        }

        // GET: Participants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participants participants = db.Participants.Find(id);
            if (participants == null)
            {
                return HttpNotFound();
            }
            return View(participants);
        }

        // POST: Participants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Participants participants = db.Participants.Find(id);
            db.Participants.Remove(participants);
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
