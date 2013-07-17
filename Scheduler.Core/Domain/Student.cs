namespace Scheduler.Core.Domain
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

    public class Student
    {
        public virtual int Id { get; set; }

        public virtual Person Person { get; set; }

        public virtual int IsQualifiedFor { get; set; }
    }
}
