using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBib.Models
{
    public interface IFilm
    {
        string FilmTitel { get; set; }
        string Filmregisseur { get; set; }

        string Bekijk();
        string ToonDetails();
    }
}
