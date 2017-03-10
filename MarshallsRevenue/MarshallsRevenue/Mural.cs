using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarshallsRevenue
{
    class Mural
    {
        public static string[] muralTypes = { "Landscape", "Seascape", "Abstract", "Children's", "Other"};
        public static string[] muralCodes = { "L", "S", "A", "C", "O" };

        public string CustomerName { get; set; }

        string code;
        string description;
        public string Description { get; }
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = "I";
                description = "Invalid";

                int index = 0;
                foreach (string muralCode in muralCodes)
                {
                    if (value == muralCode)
                    {
                        code = muralCode;
                        description = muralTypes[index];
                    }

                    index++;
                }
            }
        }
        

    }
}
