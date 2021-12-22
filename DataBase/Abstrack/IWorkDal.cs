using Core.DataAccess.Abstrack;
using Core.Entities.Results;
using Entities.Concrete;
using Entities.Concrete.Dto.WorkDetail;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface IWorkDal: IEntityRepository<Work> 
    {
        List<Work> GetList(Func<object, bool> filter);
        List<Work> GetAll(Func<object, bool> p);
        string GetString(Func<object, bool> p);
        IDataResult<int> GetWorkCount();
       List<WorkDetailDto> GetWorkDetailWithName();

    }
}
