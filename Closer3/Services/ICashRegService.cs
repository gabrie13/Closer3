using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Closer3.Models;

namespace Closer3.Services
{
    interface ICashRegService
    {
        List<CashRegViewModel> GetAll();
        CashRegViewModel FindById(int id);
        CashRegViewModel Create(CashRegViewModel cashReg);
        CashRegViewModel Save(CashRegViewModel cashReg);
        void Delete(int id);
        void Dispose();
    }
}
