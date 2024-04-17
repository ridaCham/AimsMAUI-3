﻿using System;
using Autofac;

namespace MAUIUI.Business.DependencyResoulver.AutofacResoulver
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacBusinessModule());
            var container = builder.Build();
            return container.Resolve<T>();
        }
    }
}

