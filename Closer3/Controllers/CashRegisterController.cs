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
    public class CashRegisterController : Controller
    {
        private Closer3DB db = new Closer3DB();

        // GET: CashRegister
        public ActionResult Index()
        {
            return View(db.CashRegisters.ToList());
        }

        // GET: CashRegister/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CashRegister cashRegister = db.CashRegisters.Find(id);
            if (cashRegister == null)
            {
                return HttpNotFound();
            }
            return View(cashRegister);
        }

        // GET: CashRegister/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CashRegister/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RegisterId,Cash,Check,Visa,MasterCard,Discover,Amex,GiftCard,Tax,CcTotal,Total")] CashRegister cashRegister)
        {
            if (ModelState.IsValid)
            {
                db.CashRegisters.Add(cashRegister);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cashRegister);
        }

        // GET: CashRegister/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CashRegister cashRegister = db.CashRegisters.Find(id);
            if (cashRegister == null)
            {
                return HttpNotFound();
            }
            return View(cashRegister);
        }

        // POST: CashRegister/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RegisterId,Cash,Check,Visa,MasterCard,Discover,Amex,GiftCard,Tax,CcTotal,Total")] CashRegister cashRegister)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cashRegister).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cashRegister);
        }

        // GET: CashRegister/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CashRegister cashRegister = db.CashRegisters.Find(id);
            if (cashRegister == null)
            {
                return HttpNotFound();
            }
            return View(cashRegister);
        }

        // POST: CashRegister/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CashRegister cashRegister = db.CashRegisters.Find(id);
            db.CashRegisters.Remove(cashRegister);
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
