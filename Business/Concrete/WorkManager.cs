using Business.Abstrack;
using Core.Entities.Results;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Business.Concrete
{
    public class WorkManager : IWorkService
    {
        private IWorkDal _workDal;
        public WorkManager(IWorkDal workDal)
        {
            _workDal = workDal;
        }

        public void Add(Work work)
        {
            _workDal.Add(work);
        }

        public List<Work> GetAll()
        {
            return _workDal.GetList();

        }

        public IDataResult<Work> GetById(int workId)
        {
            throw new NotImplementedException();
        }

        //work name getirildi 
        public string GetByName(int statuID)
        {
            return _workDal.GetList().Where(x => x.StatuID == statuID).FirstOrDefault().Name;
        }

        public void Update(Work work)
        {
            throw new NotImplementedException();
        }

        IDataResult<string> IWorkService.Add(Work work)
        {
           return _workDal.Add(work);
        }
    }
}
