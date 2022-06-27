using System;

namespace CustomWebAPI.IntegrationServicesClient.Models
{
    public class IBinaryData
    {
        public Guid Id { get; set; }
        public byte[] Value { get; set; }
    }
}
