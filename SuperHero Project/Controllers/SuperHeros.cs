using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero_Project.Controllers
{
    public class SuperHeros : Controller
    {
        // GET: SuperHeros
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperHeros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperHeros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHeros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperHeros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeros/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
