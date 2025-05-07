using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Book.Models;

namespace Book.Controllers
{
    public class HomeController : Controller
    {
        BookStoreContext bsc = new BookStoreContext(); 
        // GET: Home
        public ActionResult Index()
        {
            var x = bsc.Bookobj.ToList();
            return View(x);
        }

        public ActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBook(BookStore BS)
        {
            bsc.Bookobj.Add(BS);
            bsc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditBook(int id)
        {
            var fbook =bsc.Bookobj.Find(id);
            return View(fbook);
        }

        [HttpPost]
        public ActionResult EditBook(BookStore s1)
        {
            var z = bsc.Bookobj.Find(s1.Bid);
            z.Bid = s1.Bid;
            z.Btitle = s1.Btitle;
            z.Bauthor = s1.Bauthor;
            z.Bprice = s1.Bprice;
            bsc.Bookobj.AddOrUpdate(z);
            bsc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBook(int id)
        {
            var x = bsc.Bookobj.Find(id);
            bsc.Bookobj.Remove(x);
            bsc.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}