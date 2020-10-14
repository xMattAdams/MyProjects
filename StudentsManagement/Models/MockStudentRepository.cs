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
                new Student() {Id =1, Name="Jan", Surname="Kowalski", Class="1A", Email="ja.nek@student.pl", Faculty=Faculty.WEAI},
                new Student() {Id =2, Name="Marek", Surname="Bromski", Class="1A", Email="ma.rek@student.pl", Faculty=Faculty.WEZ},
                new Student() {Id =3, Name="Grzegorz", Surname="Górecki", Class="1A",Email="grze.gorz@student.pl", Faculty=Faculty.WIPL},
                new Student() {Id =4, Name="Michał", Surname="Pióro", Class="1A", Email="mi.chal@student.pl", Faculty=Faculty.WM},
                new Student() {Id =5, Name="Wojciech", Surname="Mann", Class="1A", Email="woj.ciech@student.pl", Faculty=Faculty.WWFF}
            };
        }

        public Student Add(Student student)
        {
            student.Id=_studentList.Max(s => s.Id) + 1;
            _studentList.Add(student);
            return student;
        }

        public Student Delete(int Id)
        {
            Student student =_studentList.FirstOrDefault(s => s.Id == Id);
            if (student != null)
            {
                _studentList.Remove(student);
            }
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentList;
        }

        public Student GetStudent(int Id)
        {
            return _studentList.FirstOrDefault(e => e.Id == Id);
     
        }

        public Student Update(Student studentUpdate)
        {
            Student student = _studentList.FirstOrDefault(s => s.Id == studentUpdate.Id);
            if (student != null)
            {
                student.Name = studentUpdate.Name;
                student.Faculty = studentUpdate.Faculty;
                student.Email = studentUpdate.Email;
                student.Class = studentUpdate.Class;
            }
            return student;
        }
    }
}
