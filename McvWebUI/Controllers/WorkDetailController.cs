using Business;
using Business.Abstrack;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using McvWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace McvWebUI.Controllers
{
    public class WorkDetailController : Controller
    {
        private IWorkService _workService;

        private ITeamService _teamService;
        public object WorkContex { get; private set; }

        public WorkDetailController(IWorkService workService, ITeamService teamService)
        {
            _workService = workService;

            _teamService = teamService;

        }
        public IActionResult WorkDetail()
        {
            var model = new WordDetailsViewModel
            {
                WorkDetail = new WorkDetailModel()
            };


            return View(model);
        }
        public IActionResult Index()
        {
            //    return View();S


            var data=_workService.GetWorkDetailWithTeamName();
            TeamListViewModel teamListModel = new TeamListViewModel();
            var teams = _teamService.GetAll();
            if (teams.Count > 0)
            {

                teamListModel.Team = teams;

            }
            else
            {
                //return Redirect()
                return View(new TeamListViewModel());
            }



            return View(teamListModel);
        }
       // [FromBody]
        [HttpPost]
        public IActionResult WorkDetail(WorkDetailModel workDetail)
        {

            Work work = new Work();

            work.Name = workDetail.Name;

            work.WorkID = workDetail.WorkID;

            work.Effort = workDetail.Effort;

            work.WorkType = workDetail.WorkType;

            work.TeamID = workDetail.TeamID;

            work.StatuID = workDetail.StatuID;
            
            work.Beginning = workDetail.Beginning;

            work.Creat = DateTime.Now;
            
            work.Finish = workDetail.Finish;

            work.Changing = DateTime.Now;

            _workService.Add(work);
            System.Threading.Thread.Sleep(1000);
            return RedirectToAction("Index", controllerName: "WorkDetail");
        }


    }
}
