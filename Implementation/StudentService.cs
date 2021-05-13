using SundayMobilityApplication.IStudentServices;
using SundayMobilityApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SundayMobilityApplication.Implementation
{
    public class StudentService : IStudentService
    {
        public readonly StudentDatabaseContext databaseContext;

        public StudentService(StudentDatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        public Student DeleteStudentInfo(long id)
        {
           var student=  databaseContext.student.FirstOrDefault(x => x.id == id);
            databaseContext.Entry(student).State = EntityState.Deleted;
            databaseContext.SaveChanges();
            return student;
        }

        public IEnumerable<Student> GetAllStudentInfo()
        {
            var student = databaseContext.student.ToList();
            return student;
        }

        public Student GetStudentInfoById(long id)
        {
            var Student = databaseContext.student.FirstOrDefault(x => x.id == id);
            return Student;
        }

        public Student SaveStudentInfo(Student student)
        {
              if (student != null)
                {
                    databaseContext.student.Add(student);
                    databaseContext.SaveChanges();
                    return student;
                }
            return null;
        }

        public Student UpdateStudentInfo(Student student)
        {
            if (student != null)
            {
                databaseContext.Entry(student).State = EntityState.Modified;
                databaseContext.SaveChanges();
                return student;
            }
            return null;
        }
    }
}
