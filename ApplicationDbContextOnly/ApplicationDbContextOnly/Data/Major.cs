using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ApplicationDbContextOnly.Models
{
    public partial class Job
    {
        public byte JobId { get; set; }


        [MaxLength(50), Display(Name = "المهنة بالعربي"), Required(ErrorMessage = "المهنة بالعربي")]
        public string JobArName { get; set; }


        [MaxLength(50), Display(Name = "المهنة بالإنجليزي"), Required(ErrorMessage = "المهنة بالإنجليزي")]
        public string JobEnName { get; set; }


        [MaxLength(50), Display(Name = "الوصف")]
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }

    public partial class Major
    {
        public byte MajorId { get; set; }


        [MaxLength(30),Display(Name = "التخصص بالعربي"), Required(ErrorMessage = "التخصص بالعربي")]
        public string MajorArName { get; set; }


        [MaxLength(30),Display(Name = "التخصص بالإنجليزي"), Required(ErrorMessage = "التخصص بالإنجليزي")]
        public string MajorEnName { get; set; }


        [MaxLength(50), Display(Name = "الوصف")]
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
