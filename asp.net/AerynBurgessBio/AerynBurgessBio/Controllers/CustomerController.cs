using AerynBurgessBio.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AerynBurgessBio.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerDBContext db = new CustomerDBContext();
        // GET: Customer
        public ActionResult Index()
        {
            var customers = from c in db.Customer
                            orderby c.ID
                            select c;
            return View(customers);
        }
        //GET: Employee/Details/5
        [OutputCache(Duration = int.MaxValue, VaryByParam = "id")]
        public ActionResult Details(int id)
        {
            var customer = db.Customer.SingleOrDefault(c => c.ID == id);
            return View(customer);
        }
        // POST: Employee/Create 
        [HttpPost]
        public ActionResult Create(Customer cus)
        {
            try
            {

               db.Customer.Add(cus);
               db.SaveChanges();
               return RedirectToAction("Index");
           }
           catch
           {

                return View();

           }
        }
        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = db.Customer.Single(m => m.ID == id);
            return View(customer);
        }
        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var customer = db.Customer.Single(m => m.ID == id);
                if (TryUpdateModel(customer))
                {

                    //To Do:- database code 
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(customer);
            }
            catch
            {
                return View();
            }
        }
    }
}
    
