using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWHelper.Infrastructure.Models
{
    public class Achievement : BaseIntEntity
    {
        public int id { get; set; }
        public int[] bits { get; set; }
        public int current { get; set; }
        public int max { get; set; }
        public bool done { get; set; }
        public int repeated { get; set; }
        public bool unlocked { get; set; }
    }
}
