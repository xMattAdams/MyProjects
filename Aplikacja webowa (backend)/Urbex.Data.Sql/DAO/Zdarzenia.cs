using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbex.Common.DAO
{
    public class Zdarzenia
    {
        public Zdarzenia()
        {
            this.Eksploratorzy = new HashSet<Eksploratorzy>();
        }

        public DateTime Data { get; set; }
        public string OpisZdarzenia { get; set; }

        public virtual ICollection<Eksploratorzy> Eksploratorzy { get; set; }
    }
}
