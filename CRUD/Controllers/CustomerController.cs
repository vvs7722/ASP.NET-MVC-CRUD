using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class CustomerController(ApplicationDbContext db) : Controller
    {
        private readonly ApplicationDbContext _db = db;
        public IActionResult Index()
        {
            List<Customer> customers = _db.Customers.ToList();
            return View(customers);
        }  
        public IActionResult Create()
        {
      
            return View();
        }
        [HttpPost]
          public IActionResult Created(Customer customer)
        {
          
            if (ModelState.IsValid)
            {
                _db.Customers.Add(customer);
                _db.SaveChanges();
                TempData["success"] = "Created";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            Customer? customer = _db.Customers.Find(id);
            if (id== null || id==0 || customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
        [HttpPost]
          public IActionResult Edit(Customer customer)
        {
            
         
            if (ModelState.IsValid)
            {
                _db.Customers.Update(customer);
                _db.SaveChanges();

                TempData["success"] = "Edited";
                return RedirectToAction("Index");
            }
            return View();
        } public IActionResult Delete(int? id)
        {
            Customer? customer = _db.Customers.Find(id);
            if (id== null || id==0 || customer == null)
            {
                return NotFound();
            }
            _db.Customers.Remove(customer);
            _db.SaveChanges();
            TempData["success"] = "Deleted";
            return RedirectToAction("Index");
           
        }
        
    }
}
