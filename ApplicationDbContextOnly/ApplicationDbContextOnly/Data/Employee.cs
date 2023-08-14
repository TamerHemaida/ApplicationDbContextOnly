using ApplicationDbContextOnly.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ApplicationDbContextOnly.Models
{
    public partial class Employee
    {
        public Employee()
        {
            PdfFiles = new HashSet<PdfFile>();
            PrintOrders = new HashSet<PrintOrder>();
        }
        public int EmployeeId { get; set; }

        [MaxLength(100), Display(Name = "اسم الموظف"), Required(ErrorMessage = "اسم الموظف")]
        public string EmployeeName { get; set; }


        [MaxLength(150), Display(Name = "الموبايل"), Required(ErrorMessage = "الموبايل")]
        public string Mobile { get; set; }


        [MaxLength(450), Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }



        public byte DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        [Display(Name = "مدير قسم ؟"), Required(ErrorMessage = "مدير قسم ؟")]
        public bool IsDepartmentManager { get; set; }


        public byte JobId { get; set; }
        [ForeignKey("JobId")]
        public virtual Job Job { get; set; }


        public byte MajorId { get; set; }
        [ForeignKey("MajorId")]
        public virtual Major Major { get; set; }

        public virtual ICollection<PdfFile> PdfFiles { get; set; }

        public virtual ICollection<PrintOrder>  PrintOrders { get; set; }
    }
}
