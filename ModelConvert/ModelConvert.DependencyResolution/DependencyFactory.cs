using Autofac;
using ModelConvert.Abstractions;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ModelConvert.DependencyResolution
{
    internal class DependencyFactory : IDependencyFactory
    {
        private readonly IContainer Container;

        public DependencyFactory()
        {
            var types = new List<Type>();
            types.AddRange(Assembly.GetEntryAssembly().GetTypes());
            types.AddRange(Assembly.Load("ModelConvert.Core").GetTypes());
            types.AddRange(Assembly.Load("ModelConvert.Assimp").GetTypes());

            var builder = new ContainerBuilder();
            builder.RegisterTypes(types.ToArray())
                .AsImplementedInterfaces()
                .AsSelf();

            this.Container = builder.Build();
        }

        public TDependency GetDependency<TDependency>()
        {
            return this.Container.Resolve<TDependency>();
        }
    }
}