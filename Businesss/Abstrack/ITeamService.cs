using Core.Entities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface ITeamService
    {
        public string GetByName(int teamID);

        /// <summary>
        /// Teamleri döner
        /// </summary>
        /// <returns></returns>
        List<Team> GetAll();
        IResult Add(Team team);
    }
}
