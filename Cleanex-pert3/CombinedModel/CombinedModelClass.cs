using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cleanex_pert3;

namespace Cleanex_pert3.CombinedModel
{
    public class CombinedModelClass
    {
        public IEnumerable<External_Missions> Combextmissions { get; set; }
        public IEnumerable<Employees> Combemployees { get; set; }
        public IEnumerable<Missions> CombMissions { get; set; }
    }
}