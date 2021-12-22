using Business.Abstrack;
using DataAccess.Abstrack;
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
        public string GetByName(int teamID)
        {
            return _teamDal.GetList().Where(x => x.TeamID == teamID).FirstOrDefault().Name;
        }
    }
}
