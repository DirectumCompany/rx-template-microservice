using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sungero.Logging;

namespace CustomWebAPI.Host.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CustomController : ControllerBase
  {
    internal static ILog logger => Logs.GetLogger<CustomController>();

    // GET: api/Custom
    [HttpGet]
    public IEnumerable<string> Get()
    {
      logger.Debug("Hello World!!!");
      return new string[] { "value1", "value2" };
    }

    // GET: api/Custom/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id)
    {
      return "value";
    }

    // POST: api/Custom
    [HttpPost]
    public void Post([FromBody] string value)
    {
      logger.Debug($"POST value: {value}");
    }

    // PUT: api/Custom/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
