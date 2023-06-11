using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWHelper.Infrastructure.Models
{
    public class Currency : BaseIntEntity
    {
        public int id { get; set; }
        public int value { get; set; }
    }
}
