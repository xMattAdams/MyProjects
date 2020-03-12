using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbex.Common.DAO
{
    public class Ocena
    {
        public int OcenaId { get; set; }
        public int WygladOcena { get; set; }
        public int HistoriaOcena { get; set; }
        public int ParanormalnoscOcena { get; set; }

        public virtual Eksploratorzy Eksploratorzy { get; set; }
        public virtual Obiekt Obiekt { get; set; }
    }
}
