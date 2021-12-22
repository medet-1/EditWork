using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Enum
{
    public enum WorkType
    {
        [Display(Name = "Tasarım")]
        Tasarim = 0,

        [Display(Name = "Analiz")]
        Analiz = 1,

        [Display(Name = "Test")]
        Test = 2
    }
}
