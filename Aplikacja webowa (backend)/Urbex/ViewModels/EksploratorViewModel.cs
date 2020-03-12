using System;
using System.Collections.Generic;
using Urbex.Data.Sql.DAO;


namespace Urbex.ViewModels
{
    public class UserViewModel
    {
        public int OsobaId { get; set; }
        public string OsobaImie { get; set; }
        public string OsobaNazwisko { get; set; }
        public int OsobaTelefon { get; set; }

    }
}