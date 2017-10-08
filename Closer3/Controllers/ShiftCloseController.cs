using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Closer3.Models;

namespace Closer3.Controllers
{
    public class ShiftCloseController : Controller
    {
        private Closer3DB db = new Closer3DB();

        // GET: ShiftClose
        public ActionResult Index()
        {
            return View(db.CashRegs.ToList());
        }

        // GET: ShiftClose/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CashReg cashReg = db.CashRegs.Find(id);
            if (cashReg == null)
            {
                return HttpNotFound();
            }
            return View(cashReg);
        }

        // GET: ShiftClose/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShiftClose/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CashRegisterId,Cash,Check,Visa,MasterCard,Discover,Amex,GiftCard,Tax,CcTotal,Total")] CashReg cashReg)
        {
            if (ModelState.IsValid)
            {
                db.CashRegs.Add(cashReg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cashReg);
        }

        // GET: ShiftClose/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CashReg cashReg = db.CashRegs.Find(id);
            if (cashReg == null)
            {
                return HttpNotFound();
            }
            return View(cashReg);
        }

        // POST: ShiftClose/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CashRegisterId,Cash,Check,Visa,MasterCard,Discover,Amex,GiftCard,Tax,CcTotal,Total")] CashReg cashReg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cashReg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cashReg);
        }

        // GET: ShiftClose/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CashReg cashReg = db.CashRegs.Find(id);
            if (cashReg == null)
            {
                return HttpNotFound();
            }
            return View(cashReg);
        }

        // POST: ShiftClose/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CashReg cashReg = db.CashRegs.Find(id);
            db.CashRegs.Remove(cashReg);
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
