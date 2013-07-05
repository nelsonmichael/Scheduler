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
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string HomePhone { get; set; }

        public string CellPhone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }

        public bool IsElder { get; set; }

        public bool IsMs { get; set; }
    }
}
