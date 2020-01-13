using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BallongAB.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }
}
