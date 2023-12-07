using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBib.Models
{
    public interface IMuziekAlbum
    {
        string AlbumNaam { get; set; }
        string ArtistNaam { get; set; }

        string SpeelAf();
        string ToonDetails();
    }
}
