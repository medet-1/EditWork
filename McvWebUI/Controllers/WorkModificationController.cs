using Business.Abstrack;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework.Contexts;
using McvWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MvcWebUI.Data;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace McvWebUI.Controllers
{
    public class WorkModificationController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IWorkService _workService;
        private readonly DataContext _context;

        public WorkModificationController(ILogger<HomeController> logger, IWorkService workService, DataContext context)
        {
            _logger = logger;
            _workService = workService;
            _context = context;

        }
     
        public IActionResult Update(int? Id)
        {
            var entity = _context.Works.Select(w => new WorkUpdateModel
            {
                ID = w.ID,
                WorkID = w.WorkID,
                Name = w.Name,
                Effort = w.Effort,
                StatuID = w.StatuID,
                WorkType = w.WorkType,
                Beginning = w.Beginning,
                Finish = w.Finish,
                Deleted=w.Deleted,
            }).FirstOrDefault(w => w.ID == Id);
            ViewBag.Teams = _context.Teams.ToList();
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(WorkUpdateModel model)
        {
            var entity = _context.Works.FirstOrDefault(m => m.ID == model.ID);
            entity.Name = model.Name;
            entity.Effort = model.Effort;
            entity.WorkType = model.WorkType;
            entity.StatuID = model.StatuID;
            entity.Beginning = model.Beginning;
            entity.Finish = model.Finish;
            entity.Deleted = model.Deleted;

            _context.SaveChanges();
            System.Threading.Thread.Sleep(1000);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Index()
        {
            WorkListViewModel workListViewModel = new WorkListViewModel();
            List<TeamWorkListModel> listOfTeamWork = new List<TeamWorkListModel>();
            workListViewModel.Teams = listOfTeamWork;

            var result = _workService.GetWorkDetailWithTeamName();

            if (result.Success && result.Data.Count > 0)
            {
                foreach (var item in result.Data)
                {
                    workListViewModel.Teams.Add(new TeamWorkListModel
                    {
                        ID = item.ID,
                        WorkID = item.WorkID,
                        Name = item.Name,
                        Effort = item.Effort,
                        TeamName = item.TeamName,
                        StatuID = item.StatuID

                    });
                }
            }
            return View(workListViewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Guncelleme()
        {
            return View();
        }
    }
}
