using System;
using System.Collections.Generic;
using NHibernate;

namespace LG.Treinamento.Data
{
    public class Dao<TEntity> : IDisposable
       where TEntity : class
    {
        public void Create(TEntity entity) => TryExecute(Session => Session.Save(entity));

        public void Update(TEntity entity) => TryExecute(Session => Session.Update(entity));

        public void Delete(TEntity entity) => TryExecute(Session => Session.Delete(entity));

        public TEntity Select(int id) => TryExecute(Session => Session.Get<TEntity>(id));

        public IList<TEntity> SelectAll()
        {
            try
            {
                return NHibernateClass.GetCurrentSession().CreateCriteria<TEntity>().List<TEntity>();
            }
            finally
            {
                NHibernateClass.CloseSession();
            }
        }

        private static TEntity TryExecute(Func<ISession, TEntity> func)
        {
            try
            {
                return func(NHibernateClass.GetCurrentSession());
            }
            finally
            {
                NHibernateClass.CloseSession();
            }
        }

        private static void TryExecute(Action<ISession> action)
        {
            try
            {
                var session = NHibernateClass.GetCurrentSession();
                using (var transaction = session.BeginTransaction())
                {
                    action(session);
                    transaction.Commit();
                }
            }
            finally
            {
                NHibernateClass.CloseSession();
            }
        }

        public void Dispose()
        {
            NHibernateClass.CloseSessionFactory();
            NHibernateClass.CloseSession();
            GC.SuppressFinalize(this);
        }

        public void Select(int? id)
        {
            throw new NotImplementedException();
        }
    }
}