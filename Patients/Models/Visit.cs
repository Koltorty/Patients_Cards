using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patients.Models.Enums;

namespace Patients.Models
{
    public class Visit
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime VisitDate { get; set; }

        [Required]
        public string Diagnosis { get; set; }

        [Required]
        public VisitType VisitType { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
