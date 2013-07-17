namespace Scheduler.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class UnavailableStudents
    {
        public virtual int Id { get; set; }

        public virtual Student Student { get; set; }

        public virtual DateTime StartDate { get; set; }

        public virtual DateTime? EndDate { get; set; }

        public virtual string Reason { get; set; }
    }
}
