using Microsoft.AspNetCore.Mvc;
using template_csharp_blog.Models;
using template_csharp_blog;
using System.Linq;
using System.Collections.Generic;


namespace template_csharp_blog.Controllers
{
    public class AuthorController : Controller

    {
        private ApplicationContext _context;

        public ApplicationContext Context { get => _context; set => _context = value; }

        public AuthorController()
        {
            _context = new ApplicationContext();
        }

        public IActionResult Index()
        {


            
            return View(_context.Authors.ToList());
        }

        public IActionResult Add()
        {
         
            return View(new Author());
        }

        [HttpPost]

        public IActionResult Add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id)
        {
            return View(_context.Authors.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Author author)
        {
            _context.Authors.Update(author);
            _context.SaveChanges();
            return RedirectToAction("Index", new { Id = author.Id });
        }
        public IActionResult Delete(int id)
        {
            _context.Authors.Remove(_context.Authors.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            Author posts = _context.Authors.Find(id);
            
            return View(posts);
        }

    }
}
