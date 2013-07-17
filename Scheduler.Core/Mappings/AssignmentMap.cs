namespace Scheduler.Core.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FluentNHibernate.Mapping;
    using Scheduler.Core.Domain;

    public class AssignmentMap : ClassMap<Assignment>
    {
        public AssignmentMap()
        {
            Id(x => x.Id);
            References(x => x.Student);
            References(x => x.Talk);
            References(x => x.CounselPoint);
            References(x => x.Setting);
            Map(x => x.IsHouseholder);
        }
    }
}
