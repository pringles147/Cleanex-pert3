using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cleanex_pert3;
using Cleanex_pert3.CombinedModel;

namespace Cleanex_pert3.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Schedule()
        {
            CleanDB1Entities obj = new CleanDB1Entities();
            var mymodel = new CombinedModelClass();
            mymodel.Combemployees = obj.Employees.ToList();
            mymodel.Combextmissions = obj.External_Missions.ToList();
            mymodel.CombMissions = obj.Missions.ToList();
            return View();
        }
    }
}