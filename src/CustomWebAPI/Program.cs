using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CustomWebAPI;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;
using Sungero.Logging;

namespace CustomWebAPI
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Logs.Сonfiguration.Configure();
      CreateWebHostBuilder(args).Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>()
        .UseKestrel(options =>
        {
          options.ListenAnyIP(ServiceSettings.Instance.Port);
        })
        .ConfigureLogging(logging =>
        {
          logging.ClearProviders();
          logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Warning);
          logging.AddFilter("Microsoft", Microsoft.Extensions.Logging.LogLevel.Warning);
        })
        .UseNLog();
  }
}
