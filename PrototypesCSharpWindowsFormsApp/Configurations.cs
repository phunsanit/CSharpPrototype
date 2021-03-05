using System.Collections.Generic;

namespace PrototypesCSharpWindowsFormsApp
{
    internal class Configurations
    {
        public static string environment = "DEV"; // DEV, UAT, PRODUCTION

        public static Dictionary<string, string> DSNs()
        {
            var dsns = new Dictionary<string, string>();

            switch (Configurations.environment)
            {
                case "DEV":
                    {
                        dsns["dns1"] = "Server=127.0.0.1;Database=prototype_DEV;User Id=pitt;Password=phunsanit";
                        dsns["dns1_replicate"] = "Server=127.0.0.1;Database=prototype_DEV;User Id=pitt;Password=phunsanit";
                        dsns["dns2"] = "Server=127.0.0.1;Database=prototype_DEV;User Id=pitt;Password=phunsanit";
                        dsns["dns2_replicate"] = "Server=127.0.0.1;Database=prototype_DEV;User Id=pitt;Password=phunsanit";
                    }
                    break;

                case "PRODUCTION":
                    {
                        dsns["dns1"] = "Server=127.0.0.1;Database=prototype;User Id=pitt;Password=phunsanit;";
                        dsns["dns1_replicate"] = "Server=127.0.0.1;Database=prototype;User Id=pitt;Password=phunsanit;";
                        dsns["dns2"] = "Server=127.0.0.1;Database=prototype;User Id=pitt;Password=phunsanit;";
                        dsns["dns2_replicate"] = "Server=127.0.0.1;Database=prototype;User Id=pitt;Password=phunsanit;";
                    }
                    break;

                case "UAT":
                    {
                        dsns["dns1"] = "Server=127.0.0.1;Database=prototype_UAT;User Id=pitt;Password=phunsanit";
                        dsns["dns1_replicate"] = "Server=127.0.0.1;Database=prototype_UAT;User Id=pitt;Password=phunsanit";
                        dsns["dns2"] = "Server=127.0.0.1;Database=prototype_UAT;User Id=pitt;Password=phunsanit";
                        dsns["dns2_replicate"] = "Server=127.0.0.1;Database=prototype_UAT;User Id=pitt;Password=phunsanit";
                    }
                    break;
            }

            return dsns;
        }
    }
}