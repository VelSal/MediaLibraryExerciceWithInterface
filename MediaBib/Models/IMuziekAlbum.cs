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
