using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SundayMobilityApplication.IStudentServices;
using SundayMobilityApplication.Models;


namespace SundayMobilityApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        ILogger<StudentController> logger;

        private readonly  IStudentService studentServices;

        #region constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_studentServices"></param>
        public StudentController(IStudentService _studentServices, ILogger<StudentController> _logger)
        {
            studentServices = _studentServices;
            logger= _logger;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Get all record
        /// </summary>
        /// <returns></returns>
        // GET: api/Student
        [HttpGet]
        [Route("GetAllStudentInfo")]
        public IEnumerable<Student> GetAllStudentInfo()
        {
            return studentServices.GetAllStudentInfo();
        }

        /// <summary>
        /// Get record based on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Student/5
        [HttpGet]
        [Route("GetStudentInfoById")]
        public Student GetStudentInfoById(long id)
        {
            return studentServices.GetStudentInfoById(id);
        }

        /// <summary>
        /// Save Student Info Record
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        // POST: api/Student
        [HttpPost]
        [Route("SaveStudentInfo")]
        public Student SaveStudentInfo(Student student)
        {
          return studentServices.SaveStudentInfo(student);
        }

        /// <summary>
        /// update Student Info Record
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        // PUT: api/Student/5
        [HttpPut]
        [Route("UpdateStudentInfo")]
        public Student UpdateStudentInfo(Student student)
        {
            return studentServices.UpdateStudentInfo(student);
        }


        /// <summary>
        /// Delete Student Info Record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        [Route("DeleteStudentInfo")]
        public Student DeleteStudentInfo(long id)
        {
            return studentServices.DeleteStudentInfo(id);
        }
        #endregion
    }
}
