﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController:Controller
    {

        private ComicBookRepository _comicBookRepository;
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }


        public ActionResult Index()
        {
            var comicBook = _comicBookRepository.GetComicBooks();
            return View(comicBook);
        }
        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value);
           
            return View(comicBook);
        }
    }
}