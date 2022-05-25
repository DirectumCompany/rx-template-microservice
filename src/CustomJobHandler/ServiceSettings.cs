using ConfigSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomJobHandler
{
  public class ServiceSettings
  {
    #region Константы

    /// <summary>
    /// Интервал агента по умолчанию.
    /// </summary>
    private const int DefaultInterval = 30;

    #endregion

    /// <summary>
    /// Получатель настроек.
    /// </summary>
    protected ConfigSettingsGetter ConfigSettings { get; }

    /// <summary>
    /// Инстанс синглтона.
    /// </summary>
    private static ServiceSettings _instance;
    public static ServiceSettings Instance
    {
      get
      {
        if (_instance == null)
          _instance = new ServiceSettings();
        return _instance;
      }
    }

    /// <summary>
    /// Интервал работы агента.
    /// </summary>
    public virtual int Interval => this.ConfigSettings.Get("INTERVAL", DefaultInterval);

    private ServiceSettings()
    {
      this.ConfigSettings = new ConfigSettingsGetter();
    }

  }
}
