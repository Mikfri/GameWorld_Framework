using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLib.TraceAndLogg
{
    public static class GameLog
    {
        static GameLog()
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // Uncomment the following line to log to a file
            // Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
        }

        public static void Log(string message)
        {
            Trace.WriteLine(message);
        }
    }
}
