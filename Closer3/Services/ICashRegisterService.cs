using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Closer3.Models;

namespace Closer3.Services
{
    interface ICashRegisterService
    {
        List<CashRegisterViewModel> GetAll();
        CashRegisterViewModel FindById(int id);
        CashRegisterViewModel Create(CashRegisterViewModel cashRegister);
        CashRegisterViewModel Save(CashRegisterViewModel cashRegister);
        void Delete(int id);
        void Dispose();
    }
}
