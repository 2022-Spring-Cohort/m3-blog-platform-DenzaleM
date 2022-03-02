using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using template_csharp_blog.Models;
using System.Collections.Generic;
 

namespace template_csharp_blog.Controllers
{
    public class BlogController : Controller
    {
      
        private ApplicationContext _context;

        public ApplicationContext Context { get => _context; set => _context = value; }

        public BlogController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.post = _context.Authors.ToList();
            return View(_context.Blogs.ToList());

        }

        public IActionResult Add()
        {
            //Author author = _context.Authors.Find(id);
            ViewBag.AuthorId = _context.Authors.ToList();
            return View(new Blog() { });
        }

        [HttpPost]

        public IActionResult Add( Blog blog)
        {
            ViewBag.AuthorId = _context.Authors.ToList();
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return RedirectToAction("Index", new { id = blog.AuthorId });
        }

        public IActionResult Update(int id)
        {

            Blog selectBlog = _context.Blogs.Find(id);
            return View(selectBlog);
        }

        [HttpPost]

        public IActionResult Update(int id,Blog blog)
        {
            _context.Blogs.Update(blog);
            _context.SaveChanges();
            return RedirectToAction("Index",  new { id = blog.AuthorId });


        }

        public IActionResult Remove (int id)
        {
            Blog blogtodelete= _context.Blogs.Find(id);
            _context.Blogs.Remove(blogtodelete);
            _context.SaveChanges();
            return RedirectToAction("Index",  new { id = blogtodelete.AuthorId });
        }


        public IActionResult Details(int id)
        {
            Blog blog= _context.Blogs.Find(id);
            ViewBag.post = _context.Authors.Find(blog.AuthorId);
            return View(blog);
        }

    }
}
