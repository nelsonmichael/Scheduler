namespace Scheduler.Core
{
    using Scheduler.Core.Data;
    using Scheduler.Core.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CongregationProvider : AbstractNHibernateDao<Congregation, int>, ICongregationProvider
    {

    }
}
