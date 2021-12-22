using DataAccess.Abstrack;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class StatuManager : IStatuService
    {
        private IStatuDal _statuDal;
        public StatuManager(IStatuDal statuDal)
        {
            _statuDal = statuDal;
        }


        public string GetByName(int statuID)
        {
            return _statuDal.GetList().Where(x => x.StatuID == statuID).FirstOrDefault().Name;
        }
    }


   //  return _statuDal.GetList().Where(x => x.StatuID == statuID).FirstOrDefault().Name;

}
