namespace Scheduler.Core.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FluentNHibernate.Mapping;
    using Scheduler.Core.Domain;

    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.HomePhone);
            Map(x => x.CellPhone);
            Map(x => x.Address);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.Zip);
            Map(x => x.Email);
            Map(x => x.Gender);
            Map(x => x.IsElder);
            Map(x => x.IsMs);
        }
    }
}
