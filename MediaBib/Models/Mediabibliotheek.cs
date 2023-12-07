using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBib.Models
{
    public class Mediabibliotheek
    {
        public List<object> AlleMedia { get; set; }

        public Mediabibliotheek(List<object> alleMedia)
        {
            this.AlleMedia = alleMedia;
        }

        public void VoegMediaToe(object media)
        {
            AlleMedia.Add(media);
        }
        public void ToonAlleMediaDetails()
        {
            foreach (var item in AlleMedia)
            {
                if (item is IBoek boek)
                {
                    Console.WriteLine(boek.ToonDetails()); 
                }
                else if (item is IFilm film)
                {
                    Console.WriteLine(film.ToonDetails());
                }
                else if (item is IMuziekAlbum album)
                {
                    Console.WriteLine(album.ToonDetails());
                }
                else
                {
                    Console.WriteLine("Something's wrong");
                }
            }
        }
    }
}
