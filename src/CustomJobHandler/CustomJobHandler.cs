using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Sungero.Logging;

namespace CustomJobHandler
{
  public class CustomJobHandler : BackgroundService
  {
    private static ILog logger => Logs.GetLogger<CustomJobHandler>();

    public override Task StartAsync(CancellationToken cancellationToken)
    {
      logger.Debug("CustomJobHandler started at {time}", DateTimeOffset.Now);
      return base.StartAsync(cancellationToken);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
      while (!stoppingToken.IsCancellationRequested)
      {
        logger.Info("CustomJobHandler running at: {time}", DateTimeOffset.Now);
        await Task.Delay(TimeSpan.FromSeconds(ServiceSettings.Instance.Interval), stoppingToken);
      }
    }
  }
}