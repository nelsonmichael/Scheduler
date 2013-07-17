namespace Scheduler.Core.Domain
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

    public class Talk
    {
        public virtual int Id { get; set; }

        public virtual Language Language { get; set; }

        public virtual Meeting Meeting { get; set; }

        public virtual int TalkNumber { get; set; }

        public virtual string Theme { get; set; }
    }
}
