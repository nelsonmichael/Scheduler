namespace Scheduler.Core.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FluentNHibernate.Mapping;
    using Scheduler.Core.Domain;

    public class CongregationMap : ClassMap<Congregation>
    {
        public CongregationMap()
        {
            Id(x => x.Id);
            Map(x => x.CongregationName);
            Map(x => x.WeekdayMeetingDay);
            Map(x => x.WeekdayMeetingTime);
            Map(x => x.WeekendMeetingDay);
            Map(x => x.WeekendMeetingTime);
            Map(x => x.NumberOfSchools);
            References(x => x.Language);
        }
    }
}
