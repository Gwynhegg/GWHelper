using System;

namespace GWHelper.Infrastructure.Models
{
    public class User : BaseStringEntity
    {
        public string api_key { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int world { get; set; }
        public string[] guilds { get; set; }
        public string[] guild_leader { get; set; }
        public DateTime created { get; set; }
        public string[] access { get; set; }
        public bool commander { get; set; }
        public int fractal_level { get; set; }
        public int daily_ap { get; set; }
        public int monthly_ap { get; set; }
        public int wvw_rank { get; set; }
        public string id { get; set; }
    }
}
