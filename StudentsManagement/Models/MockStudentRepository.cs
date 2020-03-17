using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.Models
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _studentList;
        
        public MockStudentRepository()
        {
            _studentList = new List<Student>()
            {
                new Student() {Id =1, Name="Jan", Surname="Kowalski", Class="1A"},
                new Student() {Id =2, Name="Marek", Surname="Bromski", Class="1A"},
                new Student() {Id =3, Name="Grzegorz", Surname="Górecki", Class="1A"},
                new Student() {Id =4, Name="Michał", Surname="Pióro", Class="1A"},
                new Student() {Id =5, Name="Wojciech", Surname="Mann", Class="1A"}
            };
        }
        
        public Student GetStudent(int Id)
        {
            return _studentList.FirstOrDefault(e => e.Id == Id);
     
        }
     
    
    }
}
