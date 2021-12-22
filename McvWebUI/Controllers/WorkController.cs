using Business;
using Business.Abstrack;
using McvWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McvWebUI.Controllers
{
    public class WorkController : Controller
    {
        IStatuService _statuService;
        IWorkService _workService;
        ITeamService _teamService;
        public WorkController(IWorkService workService,ITeamService teamService,IStatuService statuService)
        {
            _workService = workService;
            _teamService = teamService;
            _statuService = statuService;
        }

        public IActionResult Index()
        {

            
 
            return View();
        }

       
     

    }

}