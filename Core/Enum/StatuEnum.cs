using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Enum
{
    public enum StatuEnum
    {
        [Display(Name = "In-Flight")]
        InFlight = 0,

        [Display(Name = "Committed")]
        Committed = 1,

        [Display(Name = "Estimating")]
        Estimating = 2
    }
}
