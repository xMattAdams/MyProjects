using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.Models
{
    public class StudentRepoMySQL : IStudentRepository //makes changes in MySQL database
    {
        private readonly ApplicationDbContext context;

        public StudentRepoMySQL(ApplicationDbContext context)
        {
            this.context = context;
        }



        public Student Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

        public Student Delete(int id)
        {
            Student student = context.Students.Find(id);
            if (student != null)
            {
                context.Students.Remove(student);
                    context.SaveChanges();
            }
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return context.Students;
        }

        public Student GetStudent(int Id)
        {
            return context.Students.Find(Id);
            
        }

        public Student Update(Student studentUpdate)
        {
            var student = context.Students.Attach(studentUpdate);
            student.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return studentUpdate;
        }
    }
}
