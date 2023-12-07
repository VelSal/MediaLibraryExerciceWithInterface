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
