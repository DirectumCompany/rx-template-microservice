﻿namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Субъект прав")]
    public class IRecipients
    {
        //public Guid Sid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSystem { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
