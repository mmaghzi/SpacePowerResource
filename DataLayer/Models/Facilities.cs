using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
  public  class Facilities
    {
        [Key]
        public int FacilityId { get; set; }

        [Display(Name = "نام شرکت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50 , ErrorMessage = "{0} نمی تواند از 50 کاراکتر بیشتر باشد . ")]
        public string FacilityOwner { get; set; }

        [Display(Name = "نام شهر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند از 50 کاراکتر بیشتر باشد . ")]
        public string CityName { get; set; }

        [Display(Name = "نام مرکز")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند از 50 کاراکتر بیشتر باشد . ")]
        public string StationName { get; set; }

        [Display(Name = "موقعیت جغرافیایی مرکز")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند از 50 کاراکتر بیشتر باشد . ")]
        public string Geography { get; set; }

        [Display(Name = "نام امکانات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(60, ErrorMessage = "{0} نمی تواند از 60 کاراکتر بیشتر باشد . ")]
        public string FacilityName { get; set; }


        [Display(Name = "محل نصب")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند از 50 کاراکتر بیشتر باشد . ")]

        public string FcilityPosition { get; set; }

        [Display(Name = "فضای اشغالی بر حسب متر مربع")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
      
        public float OccupiedArea { get; set; }

        [Display(Name = "فیوز نصب شده")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        //[MaxLength(40, ErrorMessage = "{0} نمی تواند از 40 کاراکتر بیشتر باشد . ")]
        public float FuseValue { get; set; }

        [Display(Name = "نوع جریان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(40, ErrorMessage = "{0} نمی تواند از 50 کاراکتر بیشتر باشد . ")]
        public string CurrentKind { get; set; }

        [Display(Name = "مقدار جریان مصرفی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public float CurrentValue { get; set; }

        [Display(Name = "منبع تغذیه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند از 50 کاراکتر بیشتر باشد . ")]
        public string PowerSource { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند از 100 کاراکتر بیشتر باشد . ")]
        public string Comments { get; set; }

    
        public Facilities()
        {

        }

    }
}
