using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbex.Common.DAO
{
    public class Przedmioty
    {
        public Przedmioty()
        {
            this.Eksploratorzy = new HashSet<Eksploratorzy>();
        }

        public int PrzedmiotId { get; set; }
        public string PrzedmiotNazwa { get; set; }
        public string PrzedmiotOpis { get; set; }

        public virtual Obiekt Obiekt { get; set; }
        public virtual ICollection<Eksploratorzy> Eksploratorzy { get; set; }

    }
}
