using Microsoft.AspNetCore.Mvc;
using Student.Data;
using Student.Models;

namespace Student.Controllers
{
    public class StddetailController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public StddetailController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Stddetail> objStddetailList = _dbContext.Stddetails;
            return View(objStddetailList);
        }

        //Get
        public IActionResult Create()
        {          
            return View();
        }

       // Get
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Stddetail obj)
        {
            //To check the model is valid or not
            if (ModelState.IsValid)
            {
                _dbContext.Stddetails.Add(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //////Get
        ////public IActionResult Edit(int? id)
        ////{
        ////    if (id == null || id == 0)
        ////    {
        ////        return NotFound();
        ////    }
        ////    var stddetailFromDb = _dbContext.Stddetails.Find(id);
        ////    var stddetailFromDbFirst = _dbContext.Stddetails.FirstOrDefault(u => u.Id == id);

        ////    return View();
        ////}

        ////Get
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult (Stddetail obj)
        //{
        //    //To check the model is valid or not
        //    if (ModelState.IsValid)
        //    {
        //        _dbContext.Stddetails.Add(obj);
        //        _dbContext.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(obj);
        //}
    }
}
