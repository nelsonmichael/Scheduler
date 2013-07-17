using System;
using System.Collections.Generic;
using NHibernate;
using log4net;
using NHibernate.Criterion;
using System.Data.SqlClient;
using System.Data;

namespace  Scheduler.Core.Data
{
    public abstract class AbstractNHibernateDao<T, IdT> : IDao<T, IdT>
    {
		protected static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Loads an instance of type TypeOfListItem from the DB based on its ID.
        /// </summary>
        public T GetById(IdT id, bool shouldLock) {
            T entity;

            if (shouldLock) {
                entity = (T)NHibernateSession.Get(persitentType, id, LockMode.Upgrade);
            }
            else {
                entity = (T)NHibernateSession.Get(persitentType, id);
            }

            return entity;
        }
		/// <summary>
		/// Loads an instance of type TypeOfListItem from the DB based on its ID.
		/// ShouldLock defaults to false - use other overload to specify 'true'
		/// </summary>
		public T GetById(IdT id)
		{
			return GetById(id, false);
		}

        public virtual List<T> GetAll(params Order[] Orders)
        {
            ICriteria criteria = NHibernateSession.CreateCriteria(typeof(T));
            foreach (Order order in Orders)
                criteria.AddOrder(order);
            return criteria.List<T>() as List<T>;
        }

		public virtual List<T> GetAll(Comparison<T> Comparer)
		{
			List<T> results = GetByCriteria();
			results.Sort(Comparer);
			return results; 
		}

        /// <summary>
        /// Loads every instance of the requested type using the supplied <see cref="ICriterion" />.
        /// If no <see cref="ICriterion" /> is supplied, this behaves like <see cref="GetAll" />.
        /// </summary>
        public List<T> GetByCriteria(params ICriterion[] criterion) {
            ICriteria criteria = NHibernateSession.CreateCriteria(persitentType);

            foreach (ICriterion criterium in criterion) {
                criteria.Add(criterium);
            }
            return criteria.List<T>() as List<T>;
        }

        public List<T> GetByExample(T exampleInstance, params string[] propertiesToExclude) {
            ICriteria criteria = NHibernateSession.CreateCriteria(persitentType);
            Example example = Example.Create(exampleInstance);

            foreach (string propertyToExclude in propertiesToExclude) {
                example.ExcludeProperty(propertyToExclude);
            }

            criteria.Add(example);

            return criteria.List<T>() as List<T>;
        }
		public T GetUniqueResult(params ICriterion[] criterion)
		{
			ICriteria criteria = NHibernateSession.CreateCriteria(persitentType);

			foreach (ICriterion criterium in criterion)
				criteria.Add(criterium);
			return criteria.UniqueResult<T>();
		}

        /// <summary>
        /// Looks for a single instance using the example provided.
        /// </summary>
        /// <exception cref="NonUniqueResultException" />
        public T GetUniqueByExample(T exampleInstance, params string[] propertiesToExclude) {
            List<T> foundList = GetByExample(exampleInstance, propertiesToExclude);

            if (foundList.Count > 1) {
                throw new NonUniqueResultException(foundList.Count);
            }

            if (foundList.Count > 0) {
                return foundList[0];
            }
            else {
                return default(T);
            }
        }

		public virtual void SetAuditIdentity(string userName)
		{
			string sql = @"
				declare @binLastUpdatedBy varbinary(128)
				set @binLastUpdatedBy = cast( '" + userName + @"' as varbinary(128) )
				set context_info @binLastUpdatedBy";
			SqlCommand cmd = (SqlCommand)NHibernateSession.Connection.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = sql;
			if (null != NHibernateSession.Transaction)
				NHibernateSession.Transaction.Enlist(cmd);
			cmd.ExecuteNonQuery();
		}

        /// <summary>
        /// For entities that have assigned ID's, you must explicitly call Save to add a new one.
        /// See http://www.hibernate.org/hib_docs/reference/en/html/mapping.html#mapping-declaration-id-assigned.
        /// </summary>
        public virtual T Save(T entity) {
            // TODO: SetAuditIdentity(Toolbox.GetUserName());
			NHibernateSession.Save(entity);
			NHibernateSession.Flush();
			return entity;
        }
		public virtual T Update(T entity)
		{
			// TODO: SetAuditIdentity(Toolbox.GetUserName());
			NHibernateSession.Update(entity);
			NHibernateSession.Flush();
			return entity;
		}

        /// <summary>
        /// For entities with automatatically generated IDs, such as identity, SaveOrUpdate may 
        /// be called when saving a new entity.  SaveOrUpdate can also be called to update any 
        /// entity, even if its ID is assigned.
        /// </summary>
        public virtual T SaveOrUpdate(T entity) {
            // TODO: SetAuditIdentity(Toolbox.GetUserName());
			NHibernateSession.SaveOrUpdate(entity);
			NHibernateSession.Flush();
			return entity;
        }

        public virtual void Delete(T entity) {
			using (ITransaction transaction = NHibernateSession.BeginTransaction())
			{
                // TODO: SetAuditIdentity(Toolbox.GetUserName());
				NHibernateSession.Delete(entity);
				transaction.Commit();
			}     
        }
		public virtual void Evict(T entity)
		{
			NHibernateSession.Evict(entity);
		}

        /// <summary>
        /// Commits changes regardless of whether there's an open transaction or not
        /// </summary>
        public void CommitChanges() {
            if (NHibernateSessionManager.Instance.HasOpenTransaction()) {
                NHibernateSessionManager.Instance.CommitTransaction();
            }
            else {
                // If there's no transaction, just flush the changes
                NHibernateSessionManager.Instance.GetSession().Flush();
            }
        }

        /// <summary>
        /// Exposes the ISession used within the DAO.
        /// </summary>
        public ISession NHibernateSession {
            get {
                return NHibernateSessionManager.Instance.GetSession();
            }
        }
		public ITransaction BeginTransaction()
		{
			return NHibernateSession.BeginTransaction();
		}

        private Type persitentType = typeof(T);
    }
}
