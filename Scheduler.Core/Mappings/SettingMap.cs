namespace Scheduler.Core.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FluentNHibernate.Mapping;
    using Scheduler.Core.Domain;

    public class SettingMap : ClassMap<Setting>
    {
        public SettingMap()
        {
            Id(x => x.Id);
            References(x => x.Language);
            Map(x => x.SettingNumber);
            Map(x => x.Description);
        }
    }
}
