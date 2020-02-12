using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Models
{
    public class Area
    {
        //details of the place that the work was done
        public int Id { get; set; }
        public string Description { get; set; }
        public float M2 { get; set; }
        public int Pavement { get; set; }
        public int IdDescription { get; set; }
        public Description DescriptionObj { get; set; }
    }


}
