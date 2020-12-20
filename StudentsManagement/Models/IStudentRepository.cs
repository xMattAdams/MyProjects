﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManagement.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int Id);
        IEnumerable<Student> GetAllStudents();
        Student Add(Student student);
        Student Delete(int id);
        Student Update(Student studentUpdate);
        
    }
}
