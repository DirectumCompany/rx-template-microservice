using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using CustomWebAPI.IntegrationServicesClient;
using CustomWebAPI.IntegrationServicesClient.Exceptions;
using CustomWebAPI.IntegrationServicesClient.Models;
using CustomWebAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLog;
using Simple.OData.Client;

namespace CustomWebAPI.Services
{
  public class Service : IService
  {
    public static Logger logger = LogManager.GetCurrentClassLogger();
    private const string DefaultConfigSettingsName = @"_ConfigSettings.xml";
    public List<string> Companies()
    {
      InitOdata();
      var companiesList = new List<string>();
      var companies = Client.GetEntities<ICompanies>();
      foreach (var company in companies)
      {
        companiesList.Add(company.Name);
      }
      return companiesList;
    }

    private void InitOdata()
    {
      #region Аутентификация.
      ConfigSettingsService.SetSourcePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DefaultConfigSettingsName));
      Client.Setup(logger);
      #endregion
    }


  }
}
