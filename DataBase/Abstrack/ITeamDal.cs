using Core.DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface ITeamDal : IEntityRepository<Team>
    {
    }
}
