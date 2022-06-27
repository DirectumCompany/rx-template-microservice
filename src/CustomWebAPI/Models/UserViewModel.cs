using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sungero.Logging;

namespace CustomWebAPI.Models
{
  public class UserViewModel
  {
    public string EmailAddress { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Status { get; set; }
    public DateTime CreatedOn { get; set; }
  }
}
