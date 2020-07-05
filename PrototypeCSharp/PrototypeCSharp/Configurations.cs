using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCSharp
{
    class Configurations
    {
        public static string environment = "DEV"; // DEV, UAT, PRODUCTION

        public static Dictionary<string, string> DSNs()
        {

            var dsns = new Dictionary<string, string>();

            switch (Configurations.environment)
            {

                case "DEV":
                    {
                        dsns["dns1"] = "Server=127.0.0.1;Database=prototype_DEV;User Id=pitt;Password=phunsanit;";
                    }
                    break;

                case "UAT":
                    {
                        dsns["dns1"] = "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=MAGI-1MELCHIOR;initial catalog=prototype_DEV;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";
                    }
                    break;

                default:
                    {
                        dsns["dns1"] = "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=MAGI-1MELCHIOR;initial catalog=prototype_DEV;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";
                    }
                    break;
            }

            return dsns;
        }

    }
}
