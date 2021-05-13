using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SundayMobilityApplication.Models
{
    public partial class Student
    {
        #region Property
        /// <summary>
        /// Identifier
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public string gender { get; set; }

        /// <summary>
        /// Mobile number
        /// </summary>
        public string mobile_number { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Weight
        /// </summary>
        public double weight { get; set; }

        /// <summary>
        /// Lookup_category
        /// </summary>
        public string lookup_category { get; set; }

        /// <summary>
        /// Blood_group
        /// </summary>
        public string blood_group { get; set; }
        #endregion
    }
}
