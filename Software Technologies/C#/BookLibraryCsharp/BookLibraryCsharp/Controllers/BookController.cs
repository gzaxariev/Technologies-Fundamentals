using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BookLibraryCsharp.Data;
using BookLibraryCsharp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryCsharp.Controllers
{
    public class BookController : Controller
    {

        private readonly ApplicationDbContext database;

        public BookController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Book> books = this.database.Books.Include(b=>b.Author).ToList();
            return View(books);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(Book book)
        {

            if (ModelState.IsValid)
            {
                book.AuthorId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                this.database.Books.Add(book);
                this.database.SaveChanges();

                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");

        }

        [HttpGet]
        [Authorize]
        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Book book = this.database.Books.Include(b=>b.Author).FirstOrDefault(b=>b.Id == id);

            if (book == null)
            {
                return RedirectToAction("Index");
            }

            return View(book);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Book book = this.database.Books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return RedirectToAction("Index");
            }

            return View(book);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(Book book, int? id)
        {
            if (book== null)
            {
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                Book bookToEdit = this.database.Books.Include(b=>b.Author).FirstOrDefault(b => b.Id == id);

                if (bookToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                bookToEdit.Title = book.Title;
                bookToEdit.Description = book.Description;
                this.database.Books.Update(bookToEdit);
                this.database.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize]

        public IActionResult Delete(int? id)
        {
            Book book = this.database
                .Books.Include(b => b.Author)
                .SingleOrDefault(b => b.Id == id);

            if (book == null)
            {
                return RedirectToAction("Index");
            }

            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize]

        public IActionResult DeleteProcess(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            Book book = this.database.Books.Find(id);
            this.database.Books.Remove(book);
            this.database.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }

}