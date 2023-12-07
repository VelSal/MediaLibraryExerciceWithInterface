using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBib.Models
{
    public class Boek : IBoek
    {
        public string BoekTitel { get; set; }
        public string AutheurNaam { get ; set; }

        public Boek(string boekTitel, string autheurNaam)
        {
            this.BoekTitel = boekTitel;
            this.AutheurNaam = autheurNaam;
        }
        public string Lees()
        {
            return $"Lezen van {this.BoekTitel}";
        }
        public string ToonDetails()
        {
            return $"{this.BoekTitel} van {this.AutheurNaam}";
        }

        
    }
}
