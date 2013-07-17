namespace Scheduler.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Congregation
    {
        public virtual int Id { get; set; }

        public virtual string CongregationName { get; set; }

        public virtual DayOfWeek WeekdayMeetingDay { get; set; }

        public virtual DateTime WeekdayMeetingTime { get; set; }

        public virtual DayOfWeek WeekendMeetingDay { get; set; }

        public virtual DateTime WeekendMeetingTime { get; set; }

        public virtual int NumberOfSchools { get; set; }

        public virtual Language Language { get; set; }
    }
}
