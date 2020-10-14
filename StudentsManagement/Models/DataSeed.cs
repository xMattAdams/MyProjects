using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.Models
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(

               new Student
               {
                   Id = 1,
                   Name = "Wojciech",
                   Faculty = Faculty.WEAI,
                   Email = "woj.tek@gmail.com",
                   Class = "IIIA"
               },


               new Student
               {
                   Id = 2,
                   Name = "Marek",
                   Faculty = Faculty.WEZ,
                   Email = "ma.rek@gmail.com",
                   Class = "IIIB"
               }
               
               
               );
        }
    }
}
