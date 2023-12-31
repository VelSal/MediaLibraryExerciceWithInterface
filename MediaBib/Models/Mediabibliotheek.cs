﻿using System;
using System.Collections.Generic;

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
                Console.Write("Naar welke media bent u op zoek? (Druk op 1, 2, 3 of 4) \n\t1. Boeken \t2. Films \t3. Muziek Albums \t4. Prograam afsluiten\n");
                string userChoiceInput = Console.ReadLine();
                Console.Clear();

                if (userChoiceInput == "1")
                {
                    Console.WriteLine("Boeken in de mediabibliotheek: ");
                }
                else if (userChoiceInput == "2") {
                    Console.WriteLine("Films in de mediabibliotheek: ");
                }
                else if (userChoiceInput == "3")
                {
                    Console.WriteLine("Muziek albums in de mediabibliotheek: ");
                }

                foreach (var item in AlleMedia)
                {
                    switch (userChoiceInput)
                    {
                        case "1":
                            if (item is IBoek boek)
                            {
                                Console.WriteLine("\t" + boek.ToonDetails());
                            }
                            break;
                        case "2":
                            if (item is IFilm film)
                            {
                                Console.WriteLine("\t" + film.ToonDetails());
                            }
                            break;
                        case "3":
                            if (item is IMuziekAlbum album)
                            {
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
