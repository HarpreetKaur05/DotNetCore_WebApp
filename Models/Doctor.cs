using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [Required]
        public string DoctorName { get; set; }
        public string DoctorAddress { get; set; }
        public int DoctorAge { get; set; }
        public string RMPNumber { get; set; }
        public string HighestQualification { get; set; }
        public string Speciality { get; set; }


    }
}
