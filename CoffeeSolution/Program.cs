using Microsoft.Extensions.Hosting;
using System;
using CoffeeSolution.Common.Services;
using CoffeeSolution.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using CoffeeSolution;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
                services.AddSingleton<ICoffeeMachineService, CoffeeMachineService>()
                .AddSingleton<ICoffeeService, CoffeeService>())
    .Build();

StartCoffeeMachine(host.Services);
await host.RunAsync();


static void StartCoffeeMachine(IServiceProvider services)
{
    using IServiceScope serviceScope = services.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    ICoffeeService coffeeService = provider.GetRequiredService<ICoffeeService>();
    Orchestrator orchestrator = new Orchestrator(coffeeService);
}
