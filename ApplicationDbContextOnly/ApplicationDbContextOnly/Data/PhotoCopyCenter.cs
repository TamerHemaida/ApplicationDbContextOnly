using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ApplicationDbContextOnly.Models
{
    public partial class PhotoCopyCenter
    {
        public byte PhotoCopyCenterId { get; set; }

        [Display(Name ="الإسم")]
        public string Name { get; set; }


        [Display(Name = "العنوان")]
        public string Address { get; set; }


        [Display(Name = "الإيميل")]
        public string Email { get; set; }


        [Display(Name = "الموبايل")]
        public string Mobile { get; set; }


        [Display(Name = "الهاتف")]
        public string Phone { get; set; }


        [Display(Name = "المطبعة الإفتراضية ؟")]
        public bool IsDefaultForApplicationDbContextOnly { get; set; }


        [MaxLength(450), Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
