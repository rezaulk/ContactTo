using ContactTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactTO.Controllers
{
    public class UserController : Controller
    {
        UserDbContext Db = new UserDbContext();

        //Index
        public ActionResult Index()
        {
            var User = Db.Users.ToList();
            return View(User);
        }


        //Login
        public ActionResult Login()
        {
            var User = Db.Users.ToList();
            return View(User);
        }

        // GET: User
        public ActionResult Home()
        {
            var User = Db.Users.ToList();
            return View(User);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var user = Db.Users.Single(x => x.Uid == id);
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User collection)
        {
            try
            {
                // TODO: Add insert logic here
                Db.Users.Add(collection);
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            var user = Db.Users.Single(x => x.Uid == id);
            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User collection)
        {
            try
            {
                // TODO: Add update logic here
                var user = Db.Users.Single(x => x.Uid == id);
                user.Name = collection.Name;
                user.Phone = collection.Phone;
                user.Email = collection.Email;
                user.Address = collection.Address;
                Db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            var user = Db.Users.Single(x => x.Uid == id);
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User collection)
        {
            try
            {
                // TODO: Add delete logic here
                var user = Db.Users.Single(x => x.Uid == id);

                Db.Users.Remove(user);
                Db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
