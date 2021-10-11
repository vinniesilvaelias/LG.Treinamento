﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Reflection;

public class NHibernateClass
{
    private static readonly ISessionFactory _sessionFactory;

    static NHibernateClass() => _sessionFactory = FluentConfigure();

    public static ISession GetCurrentSession() => _sessionFactory.OpenSession();

    public static void CloseSession() => _sessionFactory.Close();

    public static void CloseSessionFactory() => _sessionFactory.Close();

    public static ISessionFactory FluentConfigure() =>
        Fluently.Configure()
            .Database(
                MsSqlConfiguration.MsSql2012
                    .ConnectionString(
                        cs =>
                        {
                            cs.Server(@"DESKTOP-4H004PB\SQL2019");
                            cs.Username("sa");
                            cs.Password("754vini!@#");
                            cs.Database("treinamento_lg");
                        })
                    )
            .Cache(
                c => c.UseQueryCache()
                    .UseSecondLevelCache()
                    .ProviderClass<NHibernate.Cache.HashtableCacheProvider>())
            .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
            .BuildSessionFactory();
}