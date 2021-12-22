using Core.Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Team :IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}
