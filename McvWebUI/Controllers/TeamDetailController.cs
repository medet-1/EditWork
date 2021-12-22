using Business.Abstrack;
using Entities.Concrete;
using McvWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class TeamDetailController : Controller
    {
        private ITeamService _teamService;
        public TeamDetailController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TeamView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TeamAddv(TeamListModel teamListModel)
        {
            Team team = new Team();
            team.Name = teamListModel.Name;
            team.Created = DateTime.Now;



            _teamService.Add(team);
            System.Threading.Thread.Sleep(1000);
            return RedirectToAction("Index", controllerName: "TeamDetail");
            
        }
    }
}
