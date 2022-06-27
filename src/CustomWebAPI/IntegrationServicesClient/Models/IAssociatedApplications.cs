using System;

namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Приложение-обработчик")]
    public class IAssociatedApplications
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public string MonitoringType { get; set; }
        public bool OpenByDefaultForReading { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
        public Guid Sid { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
