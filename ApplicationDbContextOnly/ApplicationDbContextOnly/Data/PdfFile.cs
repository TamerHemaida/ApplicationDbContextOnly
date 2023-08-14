using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ApplicationDbContextOnly.Models
{
    public partial class PdfFile
    {

        public int FileId { get; set; }

        [Required, Display(Name = "اسم الملف")]
        public string FileName { get; set; }


        [Required, Display(Name = "مسار الملف")]
        public string PhysicalFileName { get; set; }


        [Required, Display(Name = "تاريخ تحميل الملف")]
        public DateTime UploadDate { get; set; }


        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

    }
}
