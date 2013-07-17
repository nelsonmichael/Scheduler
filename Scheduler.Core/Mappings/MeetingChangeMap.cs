namespace Scheduler.Core.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FluentNHibernate.Mapping;
    using Scheduler.Core.Domain;

    public class MeetingChangeMap : ClassMap<MeetingChange>
    {
        public MeetingChangeMap()
        {
            Id(x => x.Id);
            References(x => x.Meeting);
            References(x => x.ChangeType);
        }
    }
}
