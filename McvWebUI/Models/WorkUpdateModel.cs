using Core.Enum;
using McvWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Models
{
    public class WorkUpdateModel
    {
        public int ID { get; set; }
        public int WorkID { get; set; }
        public string Name { get; set; }
        public int Effort { get; set; }
        public string TeamName { get; set; }
        public StatuEnum StatuID { get; set; }
        public WorkType WorkType { get; set; }
        public DateTime Beginning { get; set; }
        public bool Deleted { get; set; }
        public DateTime Finish { get; set; }

        public DateTime Created { get; set; }
        public string Message { get; set; }

        public int TeamId { get; set; }
        public List<TeamWorkListModel> Teams { get; set; }

    }
}
