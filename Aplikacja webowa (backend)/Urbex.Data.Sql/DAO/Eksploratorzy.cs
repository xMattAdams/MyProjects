using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbex.Data.Sql.DAO
{
    public class Eksploratorzy
    {

        public Eksploratorzy()
        {
            this.Przedmioty = new HashSet<Przedmioty>();
            this.Obiekt = new HashSet<Obiekt>();
            this.Zdarzenia = new HashSet<Zdarzenia>();
            this.Ocena = new HashSet<Ocena>();
        }


        public int OsobaId { get; set; }
        public string OsobaImie { get; set; }
        public string OsobaNazwisko { get; set; }
        public int OsobaTelefon { get; set; }

        public virtual ICollection<Przedmioty> Przedmioty { get; set; }
        public virtual ICollection<Obiekt> Obiekt { get; set; }
        public virtual ICollection<Zdarzenia> Zdarzenia { get; set; }
        public virtual ICollection<Ocena> Ocena { get; set; }

    }
}
