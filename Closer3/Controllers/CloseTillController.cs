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
    public class CloseTillController : Controller
    {
        private Closer3DB db = new Closer3DB();
        private ICashRegService _cashReg = new CashRegService();

        // GET: CloseTill
        public ActionResult Index()
        {
            return View(_cashReg.GetAll());
        }

        // GET: CloseTill/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CashRegViewModel cashReg = _cashReg.FindById(id.Value);
            if (cashReg == null)
            {
                return HttpNotFound();
            }
            return View(cashReg);
        }

        // GET: CloseTill/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CloseTill/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CashRegisterId,Cash,Check,Visa,MasterCard,Discover,Amex,GiftCard,Tax")] CashRegViewModel cashReg)
        {
            if (ModelState.IsValid)
            {
                _cashReg.Create(cashReg);
                return RedirectToAction("Index");
            }

            return View(cashReg);
        }

        // GET: CloseTill/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CashRegViewModel cashReg = _cashReg.FindById(id.Value);
            if (cashReg == null)
            {
                return HttpNotFound();
            }
            return View(cashReg);
        }

        // POST: CloseTill/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CashRegisterId,Cash,Check,Visa,MasterCard,Discover,Amex,GiftCard,Tax")] CashRegViewModel cashReg)
        {
            if (ModelState.IsValid)
            {
                _cashReg.Save(cashReg);
                return RedirectToAction("Index");
            }
            return View(cashReg);
        }

        // GET: CloseTill/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CashRegViewModel cashReg = _cashReg.FindById(id.Value);
            if (cashReg == null)
            {
                return HttpNotFound();
            }
            return View(cashReg);
        }

        // POST: CloseTill/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _cashReg.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _cashReg.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
