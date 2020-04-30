using System;
using System.Collections.Generic;
using System.Text;

namespace Dizaj_u_objektno_orijentiranom_sustavu_LV2
{
    class ConsoleLogger: ILogger
    {
        public void log (string message)
        {
            Console.WriteLine(message);
        }
    }
}
