using System;
using System.Collections.Generic;
using System.Linq;
using Urbex.Data.Sql.DAO;
using Urbex.Data.Sql;

namespace Urbex.Data.Sql.Migrations

{
    public class DatabaseSeed
    {
        private readonly UrbexDbContext _context;

        
        public DatabaseSeed(UrbexDbContext context)
        {
            _context = context;
        }

      
        public void Seed()
        {

            var EksploratorzyList = BuildEksploratorzyList();

            _context.Eksploratorzy.AddRange(EksploratorzyList);
            _context.SaveChanges();


        }

        private IEnumerable<Eksploratorzy> BuildEksploratorzyList()
        {
            var EksploratorzyList = new List<Eksploratorzy>();
            var Eksplorator = new Eksploratorzy()
            {

                OsobaId = 1,
                OsobaImie = "Jan",
                OsobaNazwisko = "Kowalski",
                OsobaTelefon = 123456789,
                ZdarzenieId=1
            };
            EksploratorzyList.Add(Eksplorator);

            var Eksplorator2 = new Eksploratorzy()
            {
                OsobaId = 2,
                OsobaImie = "Marek",
                OsobaNazwisko = "Nowak",
                OsobaTelefon = 987654321,
                ZdarzenieId = 2
            };
            EksploratorzyList.Add(Eksplorator2);

            return EksploratorzyList;
        }








    }
}