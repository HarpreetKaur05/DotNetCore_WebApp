using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime;

namespace MVCCore.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Required]
        public string DoctorName { get; set; }
        [Required]
        public string DoctorAddress { get; set; }
        [Required]
        public int DoctorAge { get; set; }
        [Required]
        public string RMPNumber { get; set; }
        [Required]
        public string HighestQualification { get; set; }
        [Required]
        public string Speciality { get; set; }
        public Int32 CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }

        public Int32? ModifiedBy = null;

        public DateTime? ModifiedDate = null;

    }
}
