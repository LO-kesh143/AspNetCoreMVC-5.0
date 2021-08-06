using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LKGGroup.Bookstore.Enums
{
    public enum LanguageEnum
    {
        [Display(Name = "Hindi lang")]
        Hindi = 10,
        [Display(Name = "English lang")]
        English = 11,
        [Display(Name = "Urdu lang")]
        Urdu = 12,
        [Display(Name = "German lang")]
        German = 13,
        [Display(Name = "Sanskrit lang")]
        Sanskrit = 14
    }
}
