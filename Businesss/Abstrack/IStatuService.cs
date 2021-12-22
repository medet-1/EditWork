using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
   public interface IStatuService
    {
        public string GetByName(int statuID);
        List<Statu> GetAll();

    }
}
