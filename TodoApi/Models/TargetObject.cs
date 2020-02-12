using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    //The object that the work will deal with, can be some plague or other object like water box
    public class TargetObject
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Collect> Collects { get; set; }
    }
}
