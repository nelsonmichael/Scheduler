namespace Scheduler.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Meeting
    {
        public virtual int Id { get; set; }

        public virtual DateTime WeekOf { get; set; }
    }
}
