using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbex.Data.Sql.DAO
{
    public class Zdarzenia
    {
        public Zdarzenia()
        {
           
            this.EksploratorzyZdarzenia = new HashSet<EksploratorzyZdarzenia>();
        }

        public DateTime Data { get; set; }
        public string OpisZdarzenia { get; set; }
        [Key]
        public int ZdarzenieId { get; set; }
       
        public virtual Obiekt Obiekt { get; set; }
        public virtual ICollection<EksploratorzyZdarzenia> EksploratorzyZdarzenia { get; set; }
    }
}
