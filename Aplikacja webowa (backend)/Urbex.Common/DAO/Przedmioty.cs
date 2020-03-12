using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbex.Data.Sql.DAO
{
    public class Przedmioty
    {
        public Przedmioty()
        {
            
            this.EksploratorzyPrzedmioty = new HashSet<EksploratorzyPrzedmioty>();
        }

        [Key]
        public int PrzedmiotId { get; set; }
        public string PrzedmiotNazwa { get; set; }
        public string PrzedmiotOpis { get; set; }

        public virtual Obiekt Obiekt { get; set; }
        

        public virtual ICollection<EksploratorzyPrzedmioty> EksploratorzyPrzedmioty { get; set; }

    }
}
