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
                Return up = await UploadFile(new List<IFormFile>(){book.Cover});
               
                if(up.Success == false || book.Cover == null)
                {
                    TempData["Error"] = "Falha no cadastro do livro";
                }
                else
                {                    
                    book.CoverPath = "/Data/Imgs/"+book.Cover.FileName;
                    book.Cover = null;
                }
                await collection.InsertOneAsync(book);
            }
            catch(Exception ex)
            {
                TempData["Error"] = ex.ToString();
            }
            return RedirectToAction("Index");
        }

        public async Task<Return> UploadFile(IList<IFormFile> files)
        {
            Return retorno = new Return{Message = "", Success = false};
            if (files is null)
            {
                throw new ArgumentNullException(nameof(files));
            }
            try
            {
                foreach (IFormFile source in files)
                {
                
                    string filename = Microsoft.Net.Http.Headers.ContentDispositionHeaderValue.Parse(source.ContentDisposition).FileName.ToString().Trim('"');

                    filename = this.EnsureCorrectFilename(filename);

                    using (FileStream output = System.IO.File.Create(this.GetPathAndFilename(filename)))
                    await source.CopyToAsync(output);
                }
                retorno.Success = true;
                retorno.Message = "";
            }
            catch(Exception ex)
            {
                retorno.Message = "Error: " + ex.ToString();
                retorno.Success = false;
            }
            return (retorno);
        }
        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("/"))
                filename = filename.Substring(filename.LastIndexOf("/") + 1);
            return filename;
        }
        private string GetPathAndFilename(string filename)
        {
            string path = this._env.ContentRootPath + "/Data/Imgs/";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return path + filename;
        }
    }
}