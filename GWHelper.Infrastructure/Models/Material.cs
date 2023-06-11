using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWHelper.Infrastructure.Models
{
    public class Material : BaseIntEntity
    {
        public int id { get; set; }
        public int category { get; set; }
        public int count { get; set; }
    }
}
