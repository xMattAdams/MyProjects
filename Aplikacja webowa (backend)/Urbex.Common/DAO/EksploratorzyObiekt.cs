using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urbex.Data.Sql.DAO;

namespace Urbex.Data.Sql

{


    public class EksploratorzyObiekt
    {
        public int EksploratorzyObiektId { get; set; }
        public int OsobaId { get; set; }
        public int ObiektId { get; set; }
        public  Obiekt Obiekt { get; set; }
        public  Eksploratorzy Eksploratorzy { get; set; }

    }

}