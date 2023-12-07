using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
