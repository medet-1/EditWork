using Core.Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.data
{
    public class Team : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}
