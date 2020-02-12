using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public DateTime MaintenanceDate { get;set;}

        public int IdUser { get; set; }

        public User UserObj { get; set; }
    }
}
