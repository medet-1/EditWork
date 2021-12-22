
using Core.DataAccess.Concrete;
using DataAccess.Abstrack;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities.Results;
using Entities.Concrete.Dto.WorkDetail;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfWorkDal : EfEntityRepositoryBase<Work, WorkContext>, IWorkDal
    {


        public List<Work> GetAll(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public List<Work> GetList(Func<object, bool> filter)
        {
            throw new NotImplementedException();
        }

        public string GetString(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public IDataResult<int> GetWorkCount()
        {
            return new SuccessDataResult<int>();
        }

        public List<WorkDetailDto> GetWorkDetailWithName()
        {
            WorkContext Work = new WorkContext();
            var result = (from t in Work.Teams
                         join w in Work.Works on t.ID equals w.TeamID
                         where w.Deleted == false
                         select new WorkDetailDto
                         {
                             Beginning = w.Beginning,
                             Created = w.Creat,
                             Deleted = w.Deleted,
                             Effort = w.Effort,
                             Finish = w.Finish,
                             Name = w.Name,
                             TeamName = t.Name,
                             WorkID = w.WorkID,
                             TeamID = t.ID,
                             StatuID = w.StatuID,
                             ID = w.ID
                             
                         }).ToList();
        //    var data = new List<WorkDetailDto>();
        //    data = result.ToList();


            return result;
        }


    }
}
