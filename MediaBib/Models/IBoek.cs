namespace MediaBib.Models
{
    public interface IBoek
    {
        string BoekTitel { get; set; }
        string AutheurNaam { get; set; }

        string Lees();
        string ToonDetails();
    }
}
