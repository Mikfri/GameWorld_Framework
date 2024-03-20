using GameWorldLib.Models.Characters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GameWorldLib.SaveFile
{
    /// <summary>
    /// Hensigten med denne klasse er at kunne gemme spillets tilstand.
    /// Heraf de forskellige Creatures, med deres nuværende attributer, koordinater, tilstand (HP), items mm.
    /// via. en XML konfigureringsfil(systemkrav!).
    /// </summary>
    public class SaveFiles
    {
        private TraceSource ts = new TraceSource("GameWorld_SaveFile");
        private static int counter = 0;
        public List<Creature> Animals = new List<Creature>();

        public string Name { get; set; }


        public SaveFiles()
        {
            ts.Switch = new SourceSwitch("Evens");
            TraceListener Listener = new XmlWriterTraceListener(new StreamWriter("GameWorld_SaveFile.xml") { AutoFlush = true });
            ts.Listeners.Add(Listener);
            counter++;
        }

        public void Save(List<Creature> creatures)
        {
            ts.TraceData(TraceEventType.Information, 1, creatures);
            ts.Flush();
            ts.Close(); // Close the trace and the trace listener
        }

        public void Load()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("GameWorld_SaveFile.xml");
        }

    }
}
