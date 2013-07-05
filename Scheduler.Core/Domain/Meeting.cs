namespace Scheduler.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Meeting
    {
        public int Id { get; set; }

        public DateTime WeekOf { get; set; }
    }
}
