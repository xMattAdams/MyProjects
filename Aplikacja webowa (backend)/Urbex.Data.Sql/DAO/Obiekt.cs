using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbex.Common.DAO
{
    public class Obiekt
    {
        public Obiekt()
        {
            this.Przedmioty = new HashSet<Przedmioty>();
            this.Eksploratorzy = new HashSet<Eksploratorzy>();
            this.Zdarzenia = new HashSet<Zdarzenia>();
            this.Ocena = new HashSet<Ocena>();
        }

        public int ObiektId { get; set; }
        public int OcenaId { get; set; }
        public string Lokalizacja { get; set; }
        public string Opis { get; set; }
        public string Nazwa { get; set; }
        public string Rodzaj { get; set; }
        public int Wiek { get; set; }


        public virtual ICollection<Ocena> Ocena { get; set; }
        public virtual ICollection<Eksploratorzy> Eksploratorzy { get; set; }
        public virtual ICollection<Zdarzenia> Zdarzenia { get; set; }
        public virtual ICollection<Przedmioty> Przedmioty { get; set; }

    }
}
