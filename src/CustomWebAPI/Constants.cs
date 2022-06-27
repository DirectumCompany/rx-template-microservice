using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWebAPI
{
  class Constants
  {

    public class ErrorTypes
    {
      public const string Error = "Error";
      public const string Warn = "Warn";
      public const string Debug = "Debug";
    }

       public class Resources
    {
      public const string IncorrecPsrnLength = "ОГРН должен содержать 13 или 15 цифр.";
      public const string IncorrecTrrcLength = "КПП должен содержать 9 цифр.";
      public const string IncorrecCodeDepartmentLength = "Код подраздленения не должен содержать больше 10 цифр.";
      public const string NotOnlyDigitsTin = "Введите ИНН, состоящий только из цифр.";
      public const string CompanyIncorrectTinLength = "Введите правильное число цифр в ИНН, для организаций - 10, для ИП - 12.";
      public const string PeopleIncorrectTinLength = "Введите правильное число цифр в ИНН, для физических лиц - 12.";
      public const string NonresidentIncorectTinLength = "Введите правильное число цифр в ИНН, для нерезидента - до 12.";
      public const string NotValidTinRegionCode = "Введите ИНН с корректным кодом региона";
      public const string NotValidTin = "Введите ИНН с корректной контрольной цифрой.";
      public const string IncorrecNceoLength = "ОКПО должен содержать 8 или 10 цифр";
    }

    public class ConfigServices
    {
      public const string IntegrationServiceUrlParamName = "INTEGRATION_SERVICE_URL";
      public const string RequestTimeoutParamName = "INTEGRATION_SERVICE_REQUEST_TIMEOUT";
      public const string UserName = "USERNAME";
      public const string Password = "PASSWORD";
    }

    public static readonly DateTimeOffset defaultDateTime = new DateTime(1971, 1, 1);
    
  }
}
