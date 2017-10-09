using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Closer3.Models;

namespace Closer3.Services
{
    public class CashRegService : ICashRegService
    {
        private Closer3DB db = new Closer3DB();

        public List<CashRegViewModel> GetAll()
        {
            var cashRegList = db.CashRegs.ToList();
            return cashRegList.Select(cr => CrDto(cr)).ToList();
        }

        private static CashRegViewModel CrDto(CashReg cr)
        {
            return new CashRegViewModel
            {
                CashRegisterId = cr.CashRegisterId,
                Cash           = cr.Cash,
                Check          = cr.Check,
                Visa           = cr.Visa, 
                MasterCard     = cr.MasterCard,
                Amex           = cr.Amex,
                Discover       = cr.Discover,
                GiftCard       = cr.GiftCard,
                Tax            = cr.Tax,

                CcTotal        = cr.Visa + 
                                 cr.MasterCard + 
                                 cr.Amex + 
                                 cr.Discover,

                Total          = cr.Visa + 
                                 cr.MasterCard + 
                                 cr.Amex + 
                                 cr.Discover + 
                                 cr.GiftCard + 
                                 cr.Cash + 
                                 cr.Check + 
                                 cr.Tax
            };
        }

        public CashRegViewModel FindById(int id)
        {
            var cashReg = db.CashRegs.Find(id);
            return cashReg != null ? CrDto(cashReg) : null;
        }

        public CashRegViewModel Create(CashRegViewModel cashReg)
        {
            var cr = fromCr(cashReg);
            db.CashRegs.Add(cr);
            db.SaveChanges();

            cr.CashRegisterId = cashReg.CashRegisterId;
            return CrDto(cr);
        }

        private static CashReg fromCr (CashRegViewModel cashReg)
        {
            var cr = new CashReg
            {
                CashRegisterId = cashReg.CashRegisterId,
                Cash           = cashReg.Cash,
                Check          = cashReg.Check,
                Visa           = cashReg.Visa,
                MasterCard     = cashReg.MasterCard,
                Amex           = cashReg.Amex,
                Discover       = cashReg.Discover,
                GiftCard       = cashReg.GiftCard,
                Tax            = cashReg.Tax
            };
            return cr;
        }

        public CashRegViewModel Save(CashRegViewModel cashReg)
        {
            var cr = fromCr(cashReg);
            db.Entry(cashReg).State = EntityState.Modified;
            db.SaveChanges();
            return CrDto(cr);
        }

        public void Delete(int id)
        {
            CashReg cashReg = db.CashRegs.Find(id);
            db.CashRegs.Remove(cashReg);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}