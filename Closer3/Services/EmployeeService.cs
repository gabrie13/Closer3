using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Closer3.Models;

namespace Closer3.Services
{
    public class EmployeeService : IEmployeeService
    {
        private Closer3DB db = new Closer3DB();

        public List<EmployeeViewModel> GetAll()
        {
            var employeeList = db.Employees.ToList();
            return employeeList.Select(emp => EmpDto(emp)).ToList();
        }

        private static EmployeeViewModel EmpDto(Employee emp)
        {
            return new EmployeeViewModel
            {
                EmployeeId  = emp.LocationId,
                FirstName   = emp.FirstName,
                LastName    = emp.LastName,
                Phone       = emp.Phone,
                DateOfHire  = emp.DateOfHire,
                Email       = emp.Email,
                Wage        = emp.Wage,
                LocationId  = emp.LocationId,
                PositionId  = emp.PositionId
            };
        }

        public EmployeeViewModel FindById(int id)
        {
            var employee = db.Employees.Find(id);
            return employee != null ? EmpDto(employee) : null;
        }

        public EmployeeViewModel Create(EmployeeViewModel employee)
        {
            var emp = fromEmp(employee);
            db.Employees.Add(emp);
            db.SaveChanges();
            employee.EmployeeId = emp.EmployeeId;
            return EmpDto(emp);
        }

        private static Employee fromEmp(EmployeeViewModel employe)
        {
            var emp = new Employee
            {
                EmployeeId   = employe.LocationId,
                FirstName    = employe.FirstName,
                LastName     = employe.LastName,
                Phone        = employe.Phone,
                DateOfHire   = employe.DateOfHire,
                Email        = employe.Email,
                Wage         = employe.Wage,
                LocationId   = employe.LocationId,
                PositionId   = employe.PositionId
            };
            return emp;
        }

        public void Delete(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}