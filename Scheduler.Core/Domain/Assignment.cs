namespace Scheduler.Core.Domain
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

    public class Assignment
    {
        public virtual int Id { get; set; }

        public virtual Student Student { get; set; }

        public virtual Talk Talk { get; set; }

        public virtual CounselPoint CounselPoint { get; set; }

        public virtual Setting Setting { get; set; }

        public virtual bool IsHouseholder { get; set; }
    }
}
