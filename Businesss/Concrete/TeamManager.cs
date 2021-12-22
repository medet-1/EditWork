using Business.Abstrack;
using Business.Constants;
using Core.Entities.Results;
using Core.Utilities.Business;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class TeamManager : ITeamService
    {
        private ITeamDal _teamDal;
        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public IResult Add(Team team)
        {
            IResult result = BusinessRules.Run(CheckIfWorkLimitExceded());
            if (result != null)
            {

                return new ErrorResult(result.Message);
                // return result;
            }

            _teamDal.Add(team);

            return new SuccessResult(Messages.TeamAdded);
        }

        public List<Team> GetAll()
        {
            return _teamDal.GetList();

        }

        public string GetByName(int teamID)
        {
            return _teamDal.GetList().Where(x => x.ID == teamID).FirstOrDefault().Name;
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

    }
}
