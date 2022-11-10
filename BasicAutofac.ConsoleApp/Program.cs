using Autofac.Core;
using Autofac;
using BasicAutofac.ConsoleApp.Demo;

IContainer Container;

void WriteDate()
{
    // Create the scope, resolve your IDateWriter,
    // use it, then dispose of the scope.
    using (var scope = Container.BeginLifetimeScope())
    {
        var writer = scope.Resolve<IDateWriter>();
        writer.WriteDate();
    }
}

var builder = new ContainerBuilder();

builder.RegisterType<ConsoleOutput>().As<IOutput>();

builder.RegisterType<TodayWriter>().As<IDateWriter>();

Container = builder.Build();

WriteDate();
