using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWHelper.Infrastructure.Models
{
    public class Item : BaseIntEntity
    {
        public int id { get; set; }
        public string chat_link { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public int level { get; set; }
        public int vendor_value { get; set; }
        public int default_skin { get; set; }
        public string[] flags { get; set; }
        public string[] game_types { get; set; }
        public string[] restrictions { get; set; }
        public Upgrade[] upgrades_into { get; set; }
        public Upgrade[] upgrades_from { get; set; }
        public object details { get; set; }
    }
}
