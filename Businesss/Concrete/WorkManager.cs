using Business.Abstrack;
using Business.Constants;
using Core.Entities.Results;
using Core.Utilities.Business;
using DataAccess.Abstrack;
using Entities.Concrete;
using Entities.Concrete.Dto.WorkDetail;
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

        public IResult Add(Work work)
        {

            //    return _workDal.Add(work); 

            IResult result = BusinessRules.Run(CheckIfWorkLimitExceded());
            if (result != null)
            {

                return new ErrorResult(result.Message);
                // return result;
            }

            _workDal.Add(work);

            return new SuccessResult(Messages.WorkAdded);
        }

        public List<Work> GetAll()
        {
            return _workDal.GetList();

        }



        public IDataResult<int> GetWorkCount()
        {
            throw new NotImplementedException();
        }

        IResult IWorkService.Update(Work work)
        {
            throw new NotImplementedException();
        }

        public IResult CheckIfWorkLimitExceded()
        {
            var result = 15;
            if (result > 15)
            {
                return new ErrorResult(Messages.WorkLimitError);
            }
            return new SuccessResult();

        }

        public string GetByName(int statuID)
        {
            throw new NotImplementedException();
        }
        //*****************************************************************//
        public IDataResult<List<WorkDetailDto>> GetWorkDetailWithTeamName()
        {
            var retVal = new SuccessDataResult<List<WorkDetailDto>>();

            retVal.Data = _workDal.GetWorkDetailWithName();
            retVal.Success = true;
            retVal.Message = null;


            return retVal;
        }



    }
}
