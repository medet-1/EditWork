using Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McvWebUI.Models
{
    public class WordDetailsViewModel
    {
        public WorkDetailModel WorkDetail { get; set; }

        public List<Team> Team { get; set; }
    }
}
