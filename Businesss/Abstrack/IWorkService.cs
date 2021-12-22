using Core.Entities.Results;
using Entities.Concrete;
using Entities.Concrete.Dto.WorkDetail;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Abstrack
{
    public interface IWorkService
    {
        List<Work> GetAll();
        string GetByName(int statuID);
        IResult Add(Work work);
        IResult Update(Work work);
        IDataResult<int> GetWorkCount();
        IDataResult<List<WorkDetailDto>> GetWorkDetailWithTeamName();
    }
}
