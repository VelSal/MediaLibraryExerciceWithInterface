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

        public void ZoekMedia()
        {
            while (true)
            {
                Console.Write("Naar welke media bent u op zoek? (Druk op 1, 2, 3 of 4) \n\t1. Boek \t2. Film \t3. Muziek Album \t4. Prograam afsluiten\n");
                string userChoiceInput = Console.ReadLine();

                foreach (var item in AlleMedia)
                {
                    switch (userChoiceInput)
                    {
                        case "1":
                            if (item is IBoek boek)
                            {
                                Console.Clear();
                                Console.WriteLine("Beschikbare boeken: ");
                                Console.WriteLine("\t" + boek.ToonDetails());
                            }
                            break;
                        case "2":
                            if (item is IFilm film)
                            {
                                Console.Clear();
                                Console.WriteLine("Beschikbare boeken: ");
                                Console.WriteLine("\t" + film.ToonDetails());
                            }
                            break;
                        case "3":
                            if (item is IMuziekAlbum album)
                            {
                                Console.Clear();
                                Console.WriteLine("Beschikbare boeken: ");
                                Console.WriteLine("\t" + album.ToonDetails());
                            }
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Tot ziens");
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Ongeldige invoer");
                            break;
                    }
                }
            }

        }
    }
}
