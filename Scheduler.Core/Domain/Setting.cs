namespace Scheduler.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Setting
    {
        public int Id { get; set; }

        public Language Language { get; set; }

        public int SettingNumber { get; set; }

        public string Description { get; set; }
    }
}
