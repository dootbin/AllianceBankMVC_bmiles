using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AllianceBankMVC_bmiles.Models;

namespace AllianceBankMVC_bmiles.Controllers
{
    public class InterestRatesController : Controller
    {
        private BankingMVCDbContext db = new BankingMVCDbContext();

        // GET: InterestRates
        public ActionResult Index()
        {
            return View(db.InterestRates.ToList());
        }

        

        // GET: InterestRates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InterestRate interestRate = db.InterestRates.Find(id);
            if (interestRate == null)
            {
                return HttpNotFound();
            }
            return View(interestRate);
        }

        // GET: InterestRates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InterestRates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RateID,RateType,RateDesc,Rate")] InterestRate interestRate)
        {
            if (ModelState.IsValid)
            {
                db.InterestRates.Add(interestRate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(interestRate);
        }

        // GET: InterestRates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InterestRate interestRate = db.InterestRates.Find(id);
            if (interestRate == null)
            {
                return HttpNotFound();
            }
            return View(interestRate);
        }

        // POST: InterestRates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RateID,RateType,RateDesc,Rate")] InterestRate interestRate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(interestRate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(interestRate);
        }

        // GET: InterestRates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InterestRate interestRate = db.InterestRates.Find(id);
            if (interestRate == null)
            {
                return HttpNotFound();
            }
            return View(interestRate);
        }

        // POST: InterestRates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InterestRate interestRate = db.InterestRates.Find(id);
            db.InterestRates.Remove(interestRate);
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
