using Entities.Concrete;
using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcWebUI.Models;

namespace McvWebUI.Models
{
    public class TeamListViewModel
    {
        public List<Team> Team { get; set; }
        public List<TeamWorkListModel> Work { get; set; }
        public List<Work> Works { get; set; }
        public List<Dictionary<int, double>> geciciDegerler { get; set; }
        public List<TeamListModel> Teams { get; set; }
    }
}
