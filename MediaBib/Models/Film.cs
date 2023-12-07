namespace MediaBib.Models
{
    public class Film : IFilm
    {
        public string FilmTitel { get; set; }
        public string Filmregisseur { get; set; }

        public Film(string filmTitel, string filmregisseur)
        {
            this.FilmTitel = filmTitel;
            this.Filmregisseur = filmregisseur;
        }

        public string Bekijk()
        {
            return $"Bekijken van {this.FilmTitel}";
        }

        public string ToonDetails()
        {
            return $"{this.FilmTitel} van {this.Filmregisseur}";
        }
    }
}
