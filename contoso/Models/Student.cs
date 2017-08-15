using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace contoso.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [Display(Name="Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name="First Name")]
        [StringLength(50, ErrorMessage="Cannot be longer than 50 char")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }

        [Required]
        [Display(Name="Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name="Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}