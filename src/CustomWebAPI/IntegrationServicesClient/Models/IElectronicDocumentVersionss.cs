using System;

namespace CustomWebAPI.IntegrationServicesClient.Models
{
    public class IElectronicDocumentVersionss
    {
        public int Number { get; set; }
        public string Note { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Modified { get; set; }
        public int Id { get; set; }
        public IBinaryData Body { get; set; }
        public IAssociatedApplications AssociatedApplication { get; set; }
    }
}
