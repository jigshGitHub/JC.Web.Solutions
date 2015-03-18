using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JC.Web.MVC4.MusicStoreApp.Models;

using JC.Web.MVC4.MusicStoreApp.Filters;
using JC.Web.MVC4.MusicStoreApp.DataServices;
namespace JC.Web.MVC4.MusicStoreApp.Controllers
{    
    [JCActionLog]
    public class StoreController : Controller
    {
        private IStoreService service;

        public StoreController(IStoreService _service)
        {
            service = _service;
        }

        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = this.service.GetGenres();

            return this.View(genres);
        }

        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            var genreModel = this.service.GetGenreByName(genre);

            return this.View(genreModel);
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var album = this.service.GetAlbum(id);
            if (album == null)
            {
                return this.HttpNotFound();
            }

            return this.View(album);
        }

        //
        // GET: /Store/GenreMenu

        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = this.service.GetGenres();

            return this.PartialView(genres);
        }

    }
}