using System;
using System.ComponentModel.DataAnnotations;


namespace Urbex.BindingModels
{
    public class CreateUser
    {
        [Required]
        [Display(Name = "Imię")]
        public string Imie { get; set; }

        [Required]
        [Display(Name = "Nazwisko")]
        public string Nazwisko { get; set; }


        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefon")]
        public int Telefon { get; set; }

       
    }
}