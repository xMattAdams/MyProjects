using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbex.Data.Sql.DAO
{
    public class Obiekt
    {
        public Obiekt()
        {
            this.Przedmioty = new HashSet<Przedmioty>();
      
            this.Zdarzenia = new HashSet<Zdarzenia>();
            this.Ocena = new HashSet<Ocena>();
            this.EksploratorzyObiekt = new HashSet<EksploratorzyObiekt>();
        }

        public int ObiektId { get; set; }
        public string Lokalizacja { get; set; }
        public string Opis { get; set; }
        public string Nazwa { get; set; }
        public string Rodzaj { get; set; }
        public int Wiek { get; set; }
        public int OsobaId { get; set; }
        public int ZdarzenieId { get; set; }
        public int OcenaId { get; set; }
        public int PrzedmiotId { get; set; }

        public virtual ICollection<Ocena> Ocena { get; set; }
     
        public virtual ICollection<Zdarzenia> Zdarzenia { get; set; }
        public virtual ICollection<Przedmioty> Przedmioty { get; set; }

        public virtual ICollection<EksploratorzyObiekt> EksploratorzyObiekt { get; set; }
    }
}
