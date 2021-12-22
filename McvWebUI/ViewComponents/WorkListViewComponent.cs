using Business.Abstrack;
using Entities.Concrete;
using McvWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McvWebUI.ViewComponents
{
    public class WorkListViewComponent : ViewComponent
    {
        private IWorkService _workService;

        private ITeamService _teamService;
        public WorkListViewComponent(ITeamService teamService, IWorkService workService)
        {
            _teamService = teamService;
            _workService = workService;
        }

        public ViewViewComponentResult Invoke()
        {

            TeamListViewModel teamListViewModel = new TeamListViewModel();


            var data = _teamService.GetAll();
            var dataList = new List<Team>();

            var data2 = _workService.GetAll();
            var datalist2 = new List<Work>();

            var dated = DateTime.Now;


            var Aylar = new string[] { "Aylar", "Ocak", "Subat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

            var list = new List<BusyShowViewModel>();
            List<Dictionary<int,double>> GeciciDegerler = new List<Dictionary<int, double>>();

            int x = 0, z = 0, y = 0;
            double basla = 0, bitis = 0, ara = 100;

        

            foreach (var team in data)
            {
                Dictionary<string, double> dd = new Dictionary<string, double>();
                BusyShowViewModel busyShowViewModel = new BusyShowViewModel();
                //{


                //    //TeamName = data.Where(x => x.ID == item.TeamID).FirstOrDefault().Name,
                //    Busy = dd

                //};

                var liste = this._workService.GetAll().Where(x => x.TeamID == team.ID && x.Deleted==false).OrderBy(x => x.Beginning);

                var llist = new List<AyGunBusyModel>();
                for (int i = 0; i < 13; i++)
                {
                    llist.Add(new AyGunBusyModel() { Year = DateTime.Now, Ay = i, Busy = 0 });
                }
                               
                foreach (var teamOfWork in liste.OrderBy(x => x.WorkID))
                {

                    //var datass = teamOfWork;

                    if (teamOfWork.Beginning.Year == teamOfWork.Finish.Year && teamOfWork.Beginning.Month == teamOfWork.Finish.Month)
                    {
                        basla = (teamOfWork.Finish.Day - teamOfWork.Beginning.Day) * 3.3;
                        x = teamOfWork.Beginning.Month;
                    //    x = decimal.Round(x, 2);
                        llist.Add(new AyGunBusyModel() { Year = teamOfWork.Beginning, Ay = x, Busy = basla });

                    }
                    else if (teamOfWork.Beginning.Year == teamOfWork.Finish.Year && teamOfWork.Finish.Month > teamOfWork.Beginning.Month)
                    {
                        basla = (30 - teamOfWork.Beginning.Day) * 3.3;
                        x = teamOfWork.Beginning.Month;
                        llist.Add(new AyGunBusyModel() { Year = teamOfWork.Beginning, Ay = x, Busy = basla });

                        for (int i = teamOfWork.Beginning.Month + 1; i < teamOfWork.Finish.Month; i++)
                        {
                            ara = 100;

                            llist.Add(new AyGunBusyModel() { Year = teamOfWork.Beginning, Ay = i, Busy = ara });
                        }
                        bitis = (teamOfWork.Finish.Day) * 3.3;
                        z = teamOfWork.Finish.Month;

                        llist.Add(new AyGunBusyModel() { Year = teamOfWork.Beginning, Ay = z, Busy = bitis });

                    }
                    else if (teamOfWork.Finish.Year > teamOfWork.Beginning.Year)
                    {
                        if ((teamOfWork.Finish.Year-teamOfWork.Beginning.Year)>1)
                        {
                            var a = (teamOfWork.Finish.Year - teamOfWork.Beginning.Year) * 12;
                            basla = (30 - teamOfWork.Beginning.Day) * 3.3;
                            x = teamOfWork.Beginning.Month;
                            llist.Add(new AyGunBusyModel() { Year = teamOfWork.Beginning, Ay = x, Busy = basla });


                            for (int i = teamOfWork.Beginning.Month + 1; i < 13; i++)
                            {
                                ara = 100;

                                llist.Add(new AyGunBusyModel() { Year = teamOfWork.Beginning, Ay = i, Busy = ara });
                            }
                            for (int i = 1; i < teamOfWork.Finish.Month + a; i++)
                            {
                                ara = 100;
                                llist.Add(new AyGunBusyModel() { Year = teamOfWork.Finish, Ay = i, Busy = ara });
                            }


                            bitis = teamOfWork.Finish.Day * 3.3;
                            z = teamOfWork.Finish.Month;

                            llist.Add(new AyGunBusyModel() { Year = teamOfWork.Finish, Ay = z, Busy = bitis });
                        }
                        else 
                        {
                            basla = (30 - teamOfWork.Beginning.Day) * 3.3;
                            x = teamOfWork.Beginning.Month;
                            llist.Add(new AyGunBusyModel() { Year = teamOfWork.Beginning, Ay = x, Busy = basla });


                            for (int i = teamOfWork.Beginning.Month + 1; i < 13; i++)
                            {
                                ara = 100;

                                llist.Add(new AyGunBusyModel() { Year = teamOfWork.Beginning, Ay = i, Busy = ara });
                            }
                            for (int i = 1; i < teamOfWork.Finish.Month ; i++)
                            {
                                ara = 100;
                                llist.Add(new AyGunBusyModel() { Year = teamOfWork.Finish, Ay = i, Busy = ara });
                            }


                            bitis = teamOfWork.Finish.Day * 3.3;
                            z = teamOfWork.Finish.Month;

                            llist.Add(new AyGunBusyModel() { Year = teamOfWork.Finish, Ay = z, Busy = bitis });
                        }                        
                        
                    }
               
                };

                Dictionary<int, double> Gecici = new Dictionary<int, double>();
                var dadadadad = llist;
                
                for (int i = 1; i <13; i++)
                { 
                    var daxxta = llist.Where(x => x.Ay == i && x.Year.Year==DateTime.Now.Year).OrderByDescending(x => x.Busy).FirstOrDefault();
                    Gecici.Add(daxxta.Ay, daxxta.Busy);

                }
                GeciciDegerler.Add(Gecici);
              
            }
            ViewData.Add(new KeyValuePair<string, object>("performans",GeciciDegerler));
            if (data.Count > 0)
                {
                    foreach (var item in data)
                    {
                        dataList.Add(item);
                    }

                    if (data2.Count > 0)
                    {
                        foreach (var item2 in data2)
                        {
                            datalist2.Add(item2);
                        }
                    }
                }
                var model = new TeamListViewModel
                {
                    Team = dataList,
                    Works = datalist2,
                    geciciDegerler=GeciciDegerler
                };
           
                return View(model);

            }

        }
    }
