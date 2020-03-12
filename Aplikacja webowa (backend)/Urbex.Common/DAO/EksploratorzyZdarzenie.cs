using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urbex.Data.Sql.DAO;

namespace Urbex.Data.Sql

{


    public class EksploratorzyZdarzenia
    {
        [Key]
        public int EksploratorzyZdarzeniaId { get; set; }
        public int OsobaId { get; set; }
        public int ZdarzenieId { get; set; }
        public  Zdarzenia Zdarzenia { get; set; }
        public  Eksploratorzy Eksploratorzy { get; set; }

    }

}