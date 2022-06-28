using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sungero.Logging;
using System;
using System.Threading;

namespace CustomJobHandler
{
  class Program
  {
    static void Main(string[] args)
    {
      Logs.Сonfiguration.Configure();
      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) =>
        {
          services.AddHostedService<CustomJobHandler>();
        });
  }
}
