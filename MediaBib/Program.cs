using MediaBib.Models;
using System;
using System.Collections.Generic;

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
            alleMedia.VoegMediaToe(new MuziekAlbum("Dark Side of the Moon", "Pink Floyd"));
            alleMedia.VoegMediaToe(new Film("Avatar", "James Cameron"));
            alleMedia.VoegMediaToe(new Boek("Monster", "Naoki Urazawa"));

            //De twee methodes hier beneden werken goed
            //alleMedia.ToonAlleMediaDetails();
            alleMedia.ZoekMedia();

            Console.ReadLine();

        }
    }
}
