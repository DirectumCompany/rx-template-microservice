using System;

namespace CustomWebAPI.IntegrationServicesClient
{
    public class EntityName : Attribute
    {
        string name;
        public EntityName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
