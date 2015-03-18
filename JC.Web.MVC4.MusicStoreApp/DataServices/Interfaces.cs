using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JC.Web.MVC4.MusicStoreApp.Models;
namespace JC.Web.MVC4.MusicStoreApp.DataServices
{
    public interface IStoreService
    {
        IList<string> GetGenreNames();

        IList<Genre> GetGenres(int max = 0);

        Genre GetGenreByName(string name);

        Album GetAlbum(int id);
    }

    public interface IMessageService
    {
        string Message { get; set; }

        string ImageUrl { get; set; }
    }
}
