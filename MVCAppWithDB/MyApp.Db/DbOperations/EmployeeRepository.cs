using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;
namespace MyApp.Db.DbOperations
{
    public class EmployeeRepository
    {
        public int AddEmployee(EmployeeModels model)
        {
            using (var context = new EmployeeDBEntities())
            {
                Employee emp = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Code = model.Code,

                };

                if (model.Address != null)
                {
                    emp.Address = new Address()
                    {
                        Details = model.Address.Details,
                        Country = model.Address.Country,
                        State = model.Address.State
                    };
                }

                context.Employee.Add(emp);

                context.SaveChanges();

                return emp.Id;
            }
        }

        public List<EmployeeModels> GetAllEmployees()
        {
            using (var context = new EmployeeDBEntities())
            {
                var result = context.Employee
                    .Select(x => new EmployeeModels()
                    {
                        Id = x.Id,
                        AddressId = x.AddressId,
                        Code = x.Code,
                        Email = x.Email,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Address = new AddressModels()
                        {
                            Id = x.Address.Id,
                            Details = x.Address.Details,
                            Country = x.Address.Country,
                            State = x.Address.State

                        }
                    }).ToList();
                return result;
            }
        }

        public EmployeeModels GetEmployee(int id)
        {
            using (var context = new EmployeeDBEntities())
            {
                var result = context.Employee
                    .Where(x => x.Id == id)
                    .Select(x => new EmployeeModels()
                    {
                        Id = x.Id,
                        AddressId = x.AddressId,
                        Code = x.Code,
                        Email = x.Email,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Address = new AddressModels()
                        {
                            Id = x.Address.Id,
                            Details = x.Address.Details,
                            Country = x.Address.Country,
                            State = x.Address.State

                        }
                    }).FirstOrDefault();
                return result;
            }
        }

        public bool UpdateEmployee(int id,EmployeeModels model)
        {
            using (var context = new EmployeeDBEntities())
            {
                var employee = new Employee();
                employee.Id = model.Id;
                employee.FirstName = model.FirstName;
                employee.LastName = model.LastName;
                employee.Email = model.Email;
                employee.Code = model.Code;
                employee.AddressId = model.AddressId;

                context.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }

        public bool DeleteEmployee(int id)
        {
            using (var context = new EmployeeDBEntities())
            {
                var emp = new Employee()
                {
                    Id = id
                };
                context.Entry(emp).State = System.Data.Entity.EntityState.Deleted; 
                context.SaveChanges();
                return false;
            }
            
        }
    }
}
