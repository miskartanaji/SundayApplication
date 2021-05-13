using SundayMobilityApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SundayMobilityApplication.IStudentServices
{
    public interface IStudentService
    {
        /// <summary>
        /// Get All Student Info
        /// </summary>
        /// <returns></returns>
        IEnumerable<Student> GetAllStudentInfo();

        /// <summary>
        /// Get Student Info By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Student GetStudentInfoById(long id);

        /// <summary>
        /// Save  Student Info
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        Student SaveStudentInfo(Student student);

        /// <summary>
        ///  Update  Student Info
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        Student UpdateStudentInfo(Student student);

        /// <summary>
        ///  Delete  Student Info
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Student DeleteStudentInfo(long id);
    }
}
