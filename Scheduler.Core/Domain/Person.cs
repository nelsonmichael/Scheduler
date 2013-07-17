namespace Scheduler.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public enum Gender
    {
        Male = 0, 

        Female = 1,
    }

    public class Person
    {
        public virtual int Id { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string HomePhone { get; set; }

        public virtual string CellPhone { get; set; }

        public virtual string Address { get; set; }

        public virtual string City { get; set; }

        public virtual string State { get; set; }

        public virtual string Zip { get; set; }

        public virtual string Email { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual bool IsElder { get; set; }

        public virtual bool IsMs { get; set; }
    }
}
