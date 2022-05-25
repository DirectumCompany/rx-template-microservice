using ConfigSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWebAPI
{
  public class ServiceSettings
  {
    #region Константы

    /// <summary>
    /// Порт по умолчанию.
    /// </summary>
    private const int DefaultPort = 12001;

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
    /// Порт сервиса.
    /// </summary>
    public virtual int Port => this.ConfigSettings.Get("PORT", DefaultPort);


    private ServiceSettings()
    {
      this.ConfigSettings = new ConfigSettingsGetter();
    }

  }
}
