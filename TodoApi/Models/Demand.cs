using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    //request of the client to a job
    public class Demand
    {
        public int Id { get; set; }

        public List<Collect> Collects { get; set; }
    }
}
