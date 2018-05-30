using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patients.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        public Genders Gender { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phone { get; set; }
    }
}
