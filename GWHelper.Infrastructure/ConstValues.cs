using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GWHelper.Infrastructure.Models;

namespace GWHelper.Infrastructure
{
    public static class ConstValues
    {
        public static Dictionary<Type, string> ENDPOINTS = new Dictionary<Type, string>()
        {
            { typeof(User), "v2/account" },
            { typeof(List<Achievement>), "v2/account/achievements" },
            { typeof(List<Material>), "v2/account/materials" },
            {typeof(Item), "v2/items"}
        };
    }
}
