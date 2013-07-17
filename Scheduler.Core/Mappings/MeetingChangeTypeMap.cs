namespace Scheduler.Core.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FluentNHibernate.Mapping;
    using Scheduler.Core.Domain;

    public class MeetingChangeTypeMap : ClassMap<MeetingChangeType>
    {
        public MeetingChangeTypeMap()
        {
            Id(x => x.Id);
            Map(x => x.MeetingChangeDescription);
        }
    }
}
