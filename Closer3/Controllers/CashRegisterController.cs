using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Closer3.Models;
using Closer3.Services;

namespace Closer3.Controllers
{
    public class CashRegisterController : Controller
    {
        private Closer3DB db = new Closer3DB();
        private readonly ICashRegisterService _cashreg = new CashRegisterService();

        // GET: CashRegister
        public ActionResult Index()
        {
            return View(_cashreg.GetAll());
        }

        // GET: CashRegister/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CashRegisterViewModel cashRegister = _cashreg.FindById(id.Value);
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RegisterId,Cash,Check,Visa,MasterCard,Discover,Amex,GiftCard,Tax,CcTotal,Total")] CashRegisterViewModel cashRegister)
        {
            if (ModelState.IsValid)
            {
                _cashreg.Create(cashRegister);
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
            CashRegisterViewModel cashRegister = _cashreg.FindById(id.Value);
            if (cashRegister == null)
            {
                return HttpNotFound();
            }
            return View(cashRegister);
        }

        // POST: CashRegister/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RegisterId,Cash,Check,Visa,MasterCard,Discover,Amex,GiftCard,Tax,CcTotal,Total")] CashRegisterViewModel cashRegister)
        {
            if (ModelState.IsValid)
            {
                _cashreg.Save(cashRegister);
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
            CashRegisterViewModel cashRegister = _cashreg.FindById(id.Value);
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
            _cashreg.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _cashreg.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
