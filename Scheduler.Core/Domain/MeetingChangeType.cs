namespace Scheduler.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MeetingChangeType
    {
        public virtual int Id { get; set; }

        public virtual string MeetingChangeDescription { get; set; }
    }
}
