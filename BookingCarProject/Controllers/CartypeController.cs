using BookingCarProject.Data;
using BookingCarProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingCarProject.Controllers
{
    public class CartypeController : Controller
    {
        private readonly BookingDbContext _db;

        public CartypeController(BookingDbContext db) 
        {
            _db = db;    
        }

        public IActionResult Index()
        {
            IEnumerable <Cartype> allCar = _db.Cartype;

            return View(allCar);
        }

        // GET METHOD
        public IActionResult Create()
        {
            return View();
        }

        // POST METHOD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cartype obj) 
        {
            if (ModelState.IsValid)
            {
                _db.Cartype.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id== null || id==0)
            {
                return NotFound();
            }
            var obj = _db.Cartype.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        // แก้ไขข้อมูล
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cartype obj)
        {
            if (ModelState.IsValid)
            {
                _db.Cartype.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // ค้นหาข้อมูล
            var obj = _db.Cartype.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            // เจอข้อมูลแล้ว
            _db.Cartype.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
