using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace Urbex.BindingModels
{
    public class EditEksplorator
    {
        //        [Required]
        [Display(Name = "Imię")]
        public string Imie { get; set; }


        //        [Required]
        [Display(Name = "Nazwisko")]
        public string Nazwisko { get; set; }


        //        [Required]
        //        [Phone]
        //        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefon")]
        public int Telefon { get; set; }

       
    }

    public class EditEksploratorValidator : AbstractValidator<EditEksplorator>
    {
        public EditEksploratorValidator()
        {
            RuleFor(x => x.Imie).NotNull();
            RuleFor(x => x.Nazwisko).NotNull();
            RuleFor(x => x.Telefon).NotNull();
            
        }
    }
}