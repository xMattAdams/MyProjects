using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbex.Data.Sql.DAO
{
    public class Eksploratorzy
    {

        public Eksploratorzy()
        {
            
            this.EksploratorzyObiekt = new HashSet<EksploratorzyObiekt>();
            this.Ocena = new HashSet<Ocena>();
            this.EksploratorzyPrzedmioty = new HashSet<EksploratorzyPrzedmioty>();
            this.EksploratorzyZdarzenia = new HashSet<EksploratorzyZdarzenia>();
            
        }

        [Key]
        public int OsobaId { get; set; }
        public string OsobaImie { get; set; }
        public string OsobaNazwisko { get; set; }
        public int OsobaTelefon { get; set; }
        public int ZdarzenieId { get; set; }

        
        public virtual ICollection<EksploratorzyObiekt> EksploratorzyObiekt { get; set; }
       
        public virtual ICollection<Ocena> Ocena { get; set; }

       
        public virtual ICollection<EksploratorzyPrzedmioty> EksploratorzyPrzedmioty { get; set; }
        public virtual ICollection<EksploratorzyZdarzenia> EksploratorzyZdarzenia { get; set; }
        
    }

    


}
