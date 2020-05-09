using System;
using System.Collections.Generic;
using JsonFlatFileDataStore;
using Microsoft.AspNetCore.Mvc;
using MBook.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
// using Microsoft.Net.Http.Headers;

namespace MBook.Controllers
{
    public class BooksController : Controller
    {
        private IWebHostEnvironment _env;
        private DataStore store;
        public BooksController(IWebHostEnvironment env)
        {
            _env = env;
            string path = _env.ContentRootPath + "/Data/Books.json";
            store = new DataStore(path);
        }

        public IActionResult Index()
        {
            List<Book> books = new List<Book>();
            var collection = store.GetCollection<Book>().AsQueryable();
            foreach(var bk in collection)
            {
                books.Add(bk);
            }
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }         
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Genre,isSerie,Volume,Resume,License")]Book book,[FromForm(Name ="Cover")] IFormFile Cover)
        {
            try
            {
                var collection = store.GetCollection<Book>();                
                book.Cover = Cover;
               
                book.CoverPath = "/Data/Imgs/"+book.Cover.FileName;
                book.Cover = null;
                
                await collection.InsertOneAsync(book);
            }
            catch(Exception ex)
            {
                TempData["Error"] = ex.ToString();
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<string> UploadFile([FromForm(Name ="file")]IFormFile file)
        {
            string filename = "";
         
            if (file is null)
            {
                throw new ArgumentNullException(nameof(file));
            }
            try
            {
            
                filename = Microsoft.Net.Http.Headers.ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.ToString().Trim('"');

                filename = this.EnsureCorrectFilename(filename);

                using (FileStream output = System.IO.File.Create(this.GetPathAndFilename(filename)))
                await file.CopyToAsync(output);
                filename = this.GetPathAndFilename(filename);
            
                filename  = "/Data/Imgs/"+file.FileName;
        
            }
            catch(Exception ex)
            {
               
            }
            return (filename);
        }
        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("/"))
                filename = filename.Substring(filename.LastIndexOf("/") + 1);
            return filename;
        }
        private string GetPathAndFilename(string filename)
        {
            
            string path = this._env.WebRootPath + "/Data/Imgs/";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return path + filename;
        }
    }
}