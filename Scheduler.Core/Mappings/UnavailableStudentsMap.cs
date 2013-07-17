namespace Scheduler.Core.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FluentNHibernate.Mapping;
    using Scheduler.Core.Domain;

    public class UnavailableStudentsMap : ClassMap<UnavailableStudents>
    {
        public UnavailableStudentsMap()
        {
            Id(x => x.Id);
            References(x => x.Student);
            Map(x => x.StartDate);
            Map(x => x.EndDate);
            Map(x => x.Reason);
        }
    }
}
