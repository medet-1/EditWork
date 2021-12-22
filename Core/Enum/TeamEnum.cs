using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Enum
{
    public enum TeamEnum
    {
        [Display(Name = "IcerikYonetimiKampanya")]
        IcerikYonetimiKampanya = 0,

        [Display(Name = "Kredi")]
        kredi = 1,
        [Display(Name = "DenemeTakimi")]
        DenemeTakimi = 2


    }
}
