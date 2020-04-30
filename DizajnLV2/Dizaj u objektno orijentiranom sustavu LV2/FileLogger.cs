using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Dizaj_u_objektno_orijentiranom_sustavu_LV2
{
    class FileLogger :ILogger
    {
        public void log(string message)
        {
         
        }
        public void log(string message, string FilePath)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(FilePath))
            {
                writer.WriteLine(message);
            }

        }
    }
}
