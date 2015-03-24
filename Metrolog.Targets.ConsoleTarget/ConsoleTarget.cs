using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroLog;
using MetroLog.Layouts;
using MetroLog.Targets;

namespace Metrolog.Targets.ConsoleTarget
{
    public class ConsoleTarget : SyncTarget
    {
        public ConsoleTarget()
            : base(new SingleLineLayout())
        { }

        public ConsoleTarget(Layout layout) : base(layout)
        {
        }

        protected override void Write(LogWriteContext context, LogEventInfo entry)
        {
            Console.WriteLine(Layout.GetFormattedString(context, entry));
        }
    }
}
