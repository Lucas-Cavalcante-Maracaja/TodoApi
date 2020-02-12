using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class User
    {
        public int Id { get; set; }

        public List<Equipment> Equipments { get; set; }

        
    }
}
