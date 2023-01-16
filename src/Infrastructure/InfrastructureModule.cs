﻿using Autofac;
using Infrastructure.DbContexts;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Infrastructure.UnitOfWorks;

namespace Infrastructure
{
    public class InfrastructureModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public InfrastructureModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf()
                 .WithParameter("connectionString", _connectionString)
                 .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                 .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
            .WithParameter("connectionString", _connectionString)
            .WithParameter("migrationAssemblyName", _migrationAssemblyName)
            .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationUnitOfWork>().As<IApplicationUnitOfWork>().InstancePerLifetimeScope();

            builder.RegisterType<ApplicationUserManager>().AsSelf();

            builder.RegisterType<ApplicationSignInManager>().AsSelf();

            builder.RegisterType<ApplicationRoleManager>().AsSelf();

            builder.RegisterType<TimeService>().As<ITimeService>().InstancePerLifetimeScope();

            builder.RegisterType<WorkerRepository>().As<IWorkerRepository>().InstancePerLifetimeScope();

            builder.RegisterType<WorkerService>().As<IWorkerService>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}