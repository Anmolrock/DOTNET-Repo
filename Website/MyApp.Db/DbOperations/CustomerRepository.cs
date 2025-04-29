using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;
namespace MyApp.Db.DbOperations
{
    public class CustomerRepository
    {
        public int AddCustomer(CustomerModel model)
        {
            using (var context = new mctcEntities())
            {
                Contact_tb contact = new Contact_tb()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Email_Id = model.Email_Id,
                    Subject = model.Subject,
                    Message = model.Message
                };
                context.Contact_tb.Add(contact);

                context.SaveChanges();

                return contact.Id;
            }
        }
    }
}
