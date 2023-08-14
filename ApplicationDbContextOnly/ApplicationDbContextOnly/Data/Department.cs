using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ApplicationDbContextOnly.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public byte DepartmentId { get; set; }


        [MaxLength(10), Display(Name = "نوع القسم"), Required(ErrorMessage = "نوع القسم")]
        public string Gender { get; set; }


        [MaxLength(15), Display(Name = "المسار الأكاديمي"), Required(ErrorMessage = "المسار الأكاديمي")]
        public string EducationPath { get; set; }


        [MaxLength(20), Display(Name = "المجمع"), Required(ErrorMessage = "المجمع")]
        public string Complex { get; set; }


        [MaxLength(30), Display(Name = "المرحلة"), Required(ErrorMessage = "المرحلة")]
        public string Stage { get; set; }


        [MaxLength(100), Display(Name = "اسم القسم"), Required(ErrorMessage = "اسم القسم")]
        public string DepartmentName { get; set; }


        [MaxLength(100)]
        public string Description { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
    }
}
