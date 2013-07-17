namespace Scheduler.Core.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FluentNHibernate.Mapping;
    using Scheduler.Core.Domain;

    public class TalkMap : ClassMap<Talk>
    {
        public TalkMap()
        {
            Id(x => x.Id);
            References(x => x.Language);
            References(x => x.Meeting);
            Map(x => x.TalkNumber);
            Map(x => x.Theme);
        }
    }
}
