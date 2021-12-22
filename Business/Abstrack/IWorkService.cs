using Core.Entities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow.CommonModels;

namespace Business.Abstrack
{
    public interface IWorkService
    {
        List<Work> GetAll();
        string GetByName(int statuID);
        Core.Entities.Results.IDataResult<string> Add(Work work);
        void Update(Work work);
       
    }
}
