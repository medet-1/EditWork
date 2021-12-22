using Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.Dto.WorkDetail
{
   public class WorkDetailDto
    {
        public int ID { get; set; }

        public int WorkID { get; set; }

        public string Name { get; set; }

        public bool Deleted { get; set; }

        public int  Effort { get; set; }

        public string TeamName { get; set; }

        public int TeamID { get; set; }

        public StatuEnum StatuID { get; set; }

        public DateTime Beginning { get; set; }

        public DateTime Finish { get; set; }

        public DateTime Created { get; set; }

        public WorkType WorkType { get; set; }



    }
}
