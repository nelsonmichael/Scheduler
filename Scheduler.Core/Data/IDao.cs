using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;



namespace  Scheduler.Core.Data
{
	public interface IDao { }
    public interface IDao<T, IdT> : IDao
    {
        T GetById(IdT id, bool shouldLock);
		T GetById(IdT id);
        List<T> GetAll(params Order[] Orders);
		List<T> GetAll(Comparison<T> Comparer);
        List<T> GetByExample(T exampleInstance, params string[] propertiesToExclude);
        T GetUniqueByExample(T exampleInstance, params string[] propertiesToExclude);
        T Save(T entity);
        T SaveOrUpdate(T entity);
		T Update(T entity);
        void Delete(T entity);
		void Evict(T entity);
        void CommitChanges();
		ITransaction BeginTransaction();
    }
}
