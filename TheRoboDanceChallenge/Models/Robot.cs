using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheRoboDanceChallenge.Models
{
    public class Robot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Powermove { get; set; }
        public int Experience { get; set; }
        public bool OutOfOrder { get; set; }
        public string Avatar { get; set; }
    }
}
