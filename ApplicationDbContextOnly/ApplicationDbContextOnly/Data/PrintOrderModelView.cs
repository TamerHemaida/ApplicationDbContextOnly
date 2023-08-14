using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDbContextOnly.Models
{
    public partial class PrintOrderModelView
    {
        public string Id { get; set; }

        [Display(Name = "اسم الملف")]
        public string FileName { get; set; }


        [Display(Name = "مسار الملف")]
        public string PhysicalFileName { get; set; }


        [Display(Name = "تاريخ تحميل الملف")]
        public DateTime UploadDate { get; set; }


        [Display(Name = "اسم المطبعة")]
        public string PhotoCopyCenterName { get; set; }

        public int PrintOrderId { get; set; }

        public long OrderNumber { get; set; }


        [Display(Name = "رقم الملف")]
        public int FileId { get; set; }


        [Display(Name = "اسم او توضيح لأمر الطباعه")]
        public string PrintOrderName { get; set; }


        [Display(Name = "تاريخ الطلب")]
        public DateTime OrderRegisterDate { get; set; }


        [Display(Name = "حجم الورق")]
        public string PageSize { get; set; }


        [Display(Name = "الحبر")]
        public string Color { get; set; }


        [Display(Name = "اتجاه الورق")]
        public string Orientation { get; set; }


        [Display(Name = "وجه الطباعه")]
        public string PrintSide { get; set; }



        [Display(Name = "عدد الصفحات المطبوعة على الورق")]
        public byte PagesPerPaper { get; set; }


        [Display(Name = "عدد النسخ المطبوعة")]
        public byte CountOfCopies { get; set; }


        [Display(Name = "نوع التدبيس")]
        public string Stapling { get; set; }


        [Display(Name = "نوع التغليف"), MaxLength(30)]
        public string CoveringType { get; set; }


        [Display(Name = "مقياس التكبير")]
        public byte PagesZoom { get; set; }


        [Display(Name = "ملاحظات")]
        public string Notes { get; set; }


        [Display(Name = "موافقة مدير القسم")]
        public string DepartmentManagerDecision { get; set; }


        [Display(Name = "آخر تعديل")]
        public DateTime DepartmentManagerLastActionDate { get; set; }


        [Display(Name = "موافقة مدير الطباعه"), MaxLength(15)]
        public string PrintManagerDecision { get; set; }


        [Display(Name = "آخر تعديل")]
        public DateTime PrintManageLastActionDate { get; set; }


        [Display(Name = "حالة الملف عند المطبعة")]
        public string PhotoCopyCenterState { get; set; }


        [Display(Name = "آخر تعديل")]
        public DateTime PhotoCopyCenterLastActionDate { get; set; }


        [Display(Name = "رفم المطبعة")]
        public byte PhotoCopyCenterId { get; set; }


        public string Email { get; set; }

        public byte DepartmentId { get; set; }

        public string Gender { get; set; }

        public string EducationPath { get; set; }

        public string Complex { get; set; }

        public string Stage { get; set; }

        public string Name { get; set; }

        public bool IsDepartmentManager { get; set; }

        public byte JobId { get; set; }

        public string JobArName { get; set; }

        public byte MajorId { get; set; }

        public string MajorArName { get; set; }

        public string Mobile { get; set; }

        public string PhotoCopyCenterMobile { get; set; }

        public string Phone { get; set; }

        public bool IsDefaultForApplicationDbContextOnly { get; set; }

    }
}
