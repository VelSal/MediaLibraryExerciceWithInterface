using MediaBib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBib
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MuziekAlbum muziek = new MuziekAlbum("Damn", "Kendrick Lamar");
            Film film = new Film("Jurrassic Park", "Steven Spielberg");
            Boek boek = new Boek("Crime and Punishment", "Fyodor Dostoevsky");

            Mediabibliotheek alleMedia = new Mediabibliotheek(new List<object>());
            alleMedia.VoegMediaToe(muziek);
            alleMedia.VoegMediaToe(film);
            alleMedia.VoegMediaToe(boek);

            alleMedia.ToonAlleMediaDetails();

            Console.ReadLine();

        }
    }
}
