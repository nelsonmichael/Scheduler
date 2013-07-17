namespace Scheduler.Core.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FluentNHibernate.Mapping;
    using Scheduler.Core.Domain;

    public class CounselPointMap : ClassMap<CounselPoint>
    {
        public CounselPointMap()
        {
            Id(x => x.Id);
            References(x => x.Language);
            Map(x => x.CounselPointNumber);
            Map(x => x.Description);
            Map(x => x.IsValidFor);
        }
    }
}
