using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPureBlue
{
    public class BlueHandler
    {
        public BlueHandler()
        {
            DayTaskRecords = new List<DayTaskRecord>();
            TaskTitles = new List<string>();
        }

        public List<DayTaskRecord> DayTaskRecords { get; set; }

        public List<string> TaskTitles { get; set; }
    }
    public class DayTaskRecord
    {
        public DateTime Date { get; set; }
        public int TaskIndex { get; set; }
    }
}
