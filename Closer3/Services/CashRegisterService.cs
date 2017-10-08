using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Closer3.Models;

namespace Closer3.Services
{
    public class CashRegisterService : ICashRegisterService
    {
        private Closer3DB db = new Closer3DB();

        public List<CashRegisterViewModel> GetAll()
        {
            var cashRegisterList = db.CashRegisters.ToList();
            return cashRegisterList.Select(cr => CrDto(cr)).ToList();
        }

        private static CashRegisterViewModel CrDto(CashRegister cr)
        {
            return new CashRegisterViewModel
            {
                CashRegisterId = cr.CashRegisterId,
                Cash           = cr.Cash,
                Check          = cr.Check,
                Visa           = cr.Visa,
                Amex           = cr.Amex,
                Discover       = cr.Discover,
                MasterCard     = cr.MasterCard,
                GiftCard       = cr.GiftCard,
                Tax            = cr.Tax,
                CcTotal        = cr.CcTotal,
                Total          = cr.Total
            };
        }

        public CashRegisterViewModel FindById(int id)
        {
            var cashRegsiter = db.CashRegisters.Find(id);
            return cashRegsiter != null ? CrDto(cashRegsiter) : null;
        }

        public CashRegisterViewModel Create(CashRegisterViewModel cashRegister)
        {
            var cr = fromCr(cashRegister);
            db.CashRegisters.Add(cr);
            db.SaveChanges();
            cashRegister.CashRegisterId = cr.CashRegisterId;
            return CrDto(cr);
        }

        private static CashRegister fromCr(CashRegisterViewModel cashRegister)
        {
            var cr = new CashRegister
            {
                CashRegisterId = cashRegister.CashRegisterId,
                Cash        = cashRegister.Cash,
                Check       = cashRegister.Check,
                Visa        = cashRegister.Visa,
                Amex        = cashRegister.Amex,
                Discover    = cashRegister.Discover,
                MasterCard  = cashRegister.MasterCard,
                GiftCard    = cashRegister.GiftCard,
                Tax         = cashRegister.Tax,
                CcTotal     = cashRegister.CcTotal,
                Total       = cashRegister.Total  
            };
            return cr;
        }

        public CashRegisterViewModel Save(CashRegisterViewModel cashRegister)
        {
            var cr = fromCr(cashRegister);
            db.Entry(cashRegister).State = EntityState.Modified;
            db.SaveChanges();

            return CrDto(cr);
        }

        public void Delete(int id)
        {
            CashRegister cashRegister = db.CashRegisters.Find(id);
            db.CashRegisters.Remove(cashRegister);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}