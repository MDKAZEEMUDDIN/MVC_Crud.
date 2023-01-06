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
                if (ModelState.IsValid && obj.phonenum.Length == 10)
                {
                    _dbContext.Stddetails.Add(obj);
                    _dbContext.SaveChanges();
                    TempData["success"] = "Stddetail created successfully";
                    return RedirectToAction("Index");
                }   
            return View(obj);
        }

        //Get
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var stddetailFromDb = _dbContext.Stddetails.Find(id);
            if(stddetailFromDb == null)
            {
                return NotFound();
            }
            return View(stddetailFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Stddetail obj)
        {
            //To check the model is valid or not
            if (ModelState.IsValid )
            {
                _dbContext.Stddetails.Update(obj);
                _dbContext.SaveChanges();
                TempData["success"] = "Stddetail Update successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //Get
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var stddetailFromDb = _dbContext.Stddetails.Find(id);
            if (stddetailFromDb == null)
            {
                return NotFound();
            }
            return View(stddetailFromDb);
        }

        //POST
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            //To check the model is valid or not
            var obj = _dbContext.Stddetails.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
                _dbContext.Stddetails.Remove(obj);
                _dbContext.SaveChanges();
            TempData["success"] = "Stddetail delete successfully";
            return RedirectToAction("Index");  
        }
    }
}
