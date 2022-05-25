using Sungero.Logging;
using System;
using System.Threading;

namespace CustomJobHandler
{
  class Program
  {
    internal static ILog logger => Logs.GetLogger<Program>();

    static void Main(string[] args)
    {
      Logs.Сonfiguration.Configure();
      logger.Debug("Hello World!!!");
      while (true)
      {
        logger.Info("Doing something....");
        Thread.Sleep(TimeSpan.FromSeconds(ServiceSettings.Instance.Interval));
      }
    }
  }
}
