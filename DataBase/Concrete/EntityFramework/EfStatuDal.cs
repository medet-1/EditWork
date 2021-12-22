using Core.DataAccess.Abstrack;
using Core.Entities.Results;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfStatuDal : IStatuDal
    {
        public void Add(Statu entity)
        {
            throw new NotImplementedException();
        }

        public Statu Get(Expression<Func<Statu, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Statu> GetList(Expression<Func<Statu, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Statu entity)
        {
            throw new NotImplementedException();
        }

      
    }
}
