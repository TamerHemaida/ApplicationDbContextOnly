using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ApplicationDbContextOnly.Models
{
    public partial class PrintOrder
    {
        public int PrintOrderId { get; set; }


        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        public byte PhotoCopyCenterId { get; set; }
        [ForeignKey("PhotoCopyCenterId")]
        public virtual PhotoCopyCenter PhotoCopyCenter { get; set; }


        [Required, Display(Name ="رقم الطلب")]
        public long OrderNumber { get; set; }


        [Required, Display(Name = "رقم الملف")]
        public int FileId { get; set; }


        [Required, Display(Name = "اسم او توضيح لأمر الطباعه"), MaxLength(200)]
        public string PrintOrderName { get; set; }


        [Required,  Display(Name = "تاريخ الطلب")]
        public DateTime OrderRegisterDate { get; set; }


        [Required, Display(Name = "حجم الورق")]
        public string PageSize { get; set; }


        [Required,  Display(Name = "الحبر")]
        public string Color { get; set; }


        [Required, Display(Name = "اتجاه الورق")]
        public string Orientation { get; set; }


        [Required, Display(Name = "وجه الطباعه")]
        public string PrintSide { get; set; }



        [Required, Display(Name = "عدد الصفحات المطبوعة على الورق")]
        public byte PagesPerPaper { get; set; }


        [Required,Display(Name = "عدد النسخ المطبوعة")]
        public byte CountOfCopies { get; set; }

        
        [Required,  Display(Name = "نوع التدبيس")]
        public string Stapling { get; set; }


        [Required,  Display(Name = "نوع التغليف"),MaxLength(30)]
        public string CoveringType { get; set; }


        [Required,  Display(Name = "مقياس التكبير")]
        public byte PagesZoom { get; set; }



        [Display(Name = "ملاحظات")]
        public string Notes { get; set; }


        [Required, Display(Name = "موافقة مدير القسم")]
        public string DepartmentManagerDecision { get; set; }


        [Required,  Display(Name = "آخر تعديل")]
        public DateTime DepartmentManagerLastActionDate { get; set; }


        [Required,  Display(Name = "موافقة مدير الطباعه"),MaxLength(15)]
        public string PrintManagerDecision { get; set; }


        [Required, Display(Name = "آخر تعديل")]
        public DateTime PrintManageLastActionDate { get; set; }



        [Required, Display(Name = "حالة الملف عند المطبعة"),MaxLength(15)]
        public string PhotoCopyCenterState { get; set; }


        [Required,  Display(Name = "آخر تعديل")]
        public DateTime PhotoCopyCenterLastActionDate { get; set; }


       
    }
   
}
