using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JC.Web.MVC4.MusicStoreApp.DataServices
{
    public class StoreService : IStoreService
    {
        MusicStoreApp.Models.MusicStoreDBEntities storeDB = new Models.MusicStoreDBEntities();

        public IList<string> GetGenreNames()
        {
            var genres = from genre in this.storeDB.Genres
                         select genre.Name;

            return genres.ToList();
        }

        public IList<Models.Genre> GetGenres(int max = 0)
        {
            return max > 0 ? this.storeDB.Genres.Take(max).ToList() : this.storeDB.Genres.ToList();
        }

        public Models.Genre GetGenreByName(string name)
        {
            var genre = this.storeDB.Genres.Include("Albums").Single(g => g.Name == name);

            return genre;
        }

        public Models.Album GetAlbum(int id)
        {
            var album = this.storeDB.Albums.Single(a => a.AlbumId == id);

            return album;
        }
    }
    public class MessageService : IMessageService
    {
        public string Message { get; set; }

        public string ImageUrl { get; set; }
    }
}