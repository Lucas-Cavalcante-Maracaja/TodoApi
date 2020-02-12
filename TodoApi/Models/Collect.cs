using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{   
    //details of what was colected for given demand
    public class Collect
    {
        public int Id { get; set; }

        public int IdDemand { get; set; }
        public int IdTargetObject { get; set; }

        public TargetObject TargetObjectObj { get; set; }
        public Demand DemandObj { get; set; }
    }
}
