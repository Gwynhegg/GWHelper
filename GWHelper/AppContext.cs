using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Core.Activators;

namespace GWHelper
{
    public class AppContext
    {
        private static AppContext _instance;

        public string ApiKey;
        public static AppContext Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AppContext();

                return _instance;
            }
        }
    }
}
