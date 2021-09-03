using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Helpers
{
    class Murder
    {
        public static void Main()
        {
            Process[] chromeWebDriverArray = Process.GetProcessesByName("chromedriver");
            Process[] firefoxWebDriverArray = Process.GetProcessesByName("geckodriver");
            Process[] edgeWebDriverArray = Process.GetProcessesByName("edgedriver");
            Process[] ieWebDriverArray = Process.GetProcessesByName("IEDriverServer");
            Process[] webDriverProcessArray = chromeWebDriverArray.Union(firefoxWebDriverArray).Union(edgeWebDriverArray).Union(ieWebDriverArray).ToArray();
            foreach (var proc in webDriverProcessArray)
            {
                proc.Kill();
            }
        }
    }
}
