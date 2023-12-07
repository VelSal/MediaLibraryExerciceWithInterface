namespace MediaBib.Models
{
    public class MuziekAlbum : IMuziekAlbum
    {
        public string AlbumNaam { get; set; }
        public string ArtistNaam { get; set; }

        public MuziekAlbum(string albumNaam, string artistNaam)
        {
            this.AlbumNaam = albumNaam;
            this.ArtistNaam = artistNaam;
        }

        public string SpeelAf()
        {
            return $"Afspelen van {this.AlbumNaam}";
        }

        public string ToonDetails()
        {
            return $"{this.AlbumNaam} van {this.ArtistNaam}";
        }

    }
}
