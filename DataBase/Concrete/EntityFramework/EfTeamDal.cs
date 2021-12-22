using Core.DataAccess.Abstrack;
using Core.DataAccess.Concrete.EntityFramework;
using Core.Entities.Results;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfTeamDal : EfEntityRepositoryBase<Team, WorkContext>, ITeamDal 
    {




    }
}
