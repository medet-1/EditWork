using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Models
{
    public class BusyShowViewModel
    {
        public string TeamName { get; set; }
        public Dictionary<string,double> Busy { get; set; }
        

    }
}
