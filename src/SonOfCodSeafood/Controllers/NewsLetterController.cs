using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCodSeafood.Models;


namespace SonOfCodSeafood.Controllers
{
    public class NewsLetterController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //View all emails
        public IActionResult Index()
        {
            return View(db.NewsLetters.ToList());
        }
        //Create a New email
        [HttpPost]
        public IActionResult Create(NewsLetter newsletter)
        {
            
                db.NewsLetters.Add(newsletter);
                db.SaveChanges();
            
                return RedirectToAction("Index", "Home");
        }
        //Delete an email
        public IActionResult Delete(int id)
        {
            var thisEmail = db.NewsLetters.FirstOrDefault(e => e.NewsLetterId == id);
            return View(thisEmail);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisEmail = db.NewsLetters.FirstOrDefault(e => e.NewsLetterId == id);
            db.NewsLetters.Remove(thisEmail);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
