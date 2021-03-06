﻿namespace Scheduler.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Setting
    {
        public virtual int Id { get; set; }

        public virtual Language Language { get; set; }

        public virtual int SettingNumber { get; set; }

        public virtual string Description { get; set; }
    }
}
