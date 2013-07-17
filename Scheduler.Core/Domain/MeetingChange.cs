namespace Scheduler.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MeetingChange
    {
        public virtual int Id { get; set; }

        public virtual Meeting Meeting { get; set; }

        public virtual MeetingChangeType ChangeType { get; set; }
    }
}
