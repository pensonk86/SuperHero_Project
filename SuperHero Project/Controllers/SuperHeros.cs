using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero_Project.Data;
using SuperHero_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero_Project.Controllers
{
    public class SuperHeroes : Controller
    {
        private ApplicationDbContext _context; 
        public SuperHeroes(ApplicationDbContext context)
        {
            _context = context;

        }
        
        // GET: SuperHeros
        public ActionResult Index()
        {
            var superheros = _context.SuperHeroes.ToList(); // 
            return View(superheros);

        }

        // GET: SuperHeros/Details/5
        public ActionResult Details(int id)
        {
            var superhero = _context.SuperHeroes.Find(id);
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
        public ActionResult Create(SuperHero superhero)
        {
            try
            {
                _context.SuperHeroes.Add(superhero);
                _context.SaveChanges();
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
            SuperHero superhero = _context.Superheros.FirstDefault(s => s.id == id);
            return View();
        }

        // POST: SuperHeros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                SuperHero superheroToAdd = _context.SuperHeroes.First(s => s.id == id);
                superheroToAdd.Name = collection["Name"];
                superheroToAdd.AlterEgo = collection["AlterEgo"];
                superheroToAdd.PrimarySuperheroAbility = collection["PrimarySuperheroAbility"];
                superheroToAdd.SecondarySuperHeroAbility = collection["SecondarySuperheroAbility"];
                superheroToAdd.Catchphrase = collection["Catchphrase"];
                _context.SaveChanges();

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
            SuperHero superhero = _context.SuperHeroes.First(s => s.id == id);
            return View(superhero);
        }

        // POST: SuperHeros/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                SuperHero superhero = _context.SuperHeroes.First(s => s.id == id);
                _context.SuperHeroes.Remove(superhero);
                _context.SaveChanges();
               
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
