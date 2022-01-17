using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LovePlanet.Domain.Core;
using LovePlanet.Domain.Interfaces;
using LovePlanet.Services.Interfaces;

namespace Love_Planet.Controllers
{
    public class HomeController : Controller
    {
        //вот тут начался страх, что щас нифига не заработает(
        //нужно реализовать IRel_of_pep
        IPeopleRepository p_repo;
        IRelationsRepository r_repo;
        IRel_of_pep rel_pep;

        public HomeController(IPeopleRepository p_rp, IRel_of_pep r_p)
        {
            p_repo = p_rp;
            rel_pep = r_p;
        }

        public ActionResult Index()
        {
            var people = p_repo.GetPeoplesList();
            return View(people);
        }

        public ActionResult Relation_us(int id1, int id2, int rel_id)
        {
            People people1 = p_repo.GetPeople(id1);
            People people2 = p_repo.GetPeople(id2);
            Relations relations = r_repo.GetRelations(rel_id);
            rel_pep.MakeRel_of_pep(people1, people2, relations);
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            p_repo.Dispose();
            r_repo.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}