using Core.Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete 
{
    public class Statu  : IEntity
    {
        public int StatuID { get; set; }
        public string Name { get; set; }
    }
}
