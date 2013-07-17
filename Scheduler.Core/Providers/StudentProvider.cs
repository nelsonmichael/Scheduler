namespace Scheduler.Core.Providers
{
    using Scheduler.Core.Data;
    using Scheduler.Core.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StudentProvider : AbstractNHibernateDao<Student, int>, IStudentProvider
    {

    }
}
