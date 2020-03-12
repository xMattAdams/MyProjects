using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urbex.Data.Sql.DAO;

namespace Urbex.Data.Sql

{


    public class EksploratorzyPrzedmioty 
    {
        [Key]
        public int EksploratorzyPrzedmiotyId { get; set; }
        public int OsobaId { get; set; }
        public int PrzedmiotId { get; set; }
        public  Przedmioty Przedmioty { get; set; }
        public  Eksploratorzy Eksploratorzy { get; set; }

    }

}