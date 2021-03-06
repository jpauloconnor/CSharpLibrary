﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_money_machine_console_app
{
    class CustomerService
    {
        private AtmDBContextEntities db = new AtmDBContextEntities();
        
        public void CreateCustomer(string first, string last)
        {
            var entity = new Customer
            {
                FirstName = first,
                LastName = last
            };
            using(var ctx = new AtmDBContextEntities())
            {
                ctx.Customers.Add(entity);
                ctx.SaveChanges();
            }
            Console.WriteLine("Hello, {0}. Your id number is, {1}", entity.FirstName, entity.CustomerID);
        }
        public void GreetByLast(int? id)
        {
            //Get the id.
            var query = from n in db.Accounts
                        where n.AccountID == id
                        select n;
            foreach(var name in query)
            {
                Console.WriteLine("Hello, {0}", name.Customer.FirstName);
            }
        }
        public Customer GetCustomerID(int? id)
        {
            Customer customerId = db.Customers.Find(id);
            if (customerId == null)
            {
                Console.WriteLine("Sorry, we couldn't find that id.");
            }
            return customerId;
        }
        public void ShowCustomerInformation() { }
    }
}
