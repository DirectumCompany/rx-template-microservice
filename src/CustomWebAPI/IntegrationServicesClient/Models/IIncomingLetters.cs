using System;

namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Входящее письмо")]
    class IIncomingLetters : IOfficialDocuments
    {
        public DateTimeOffset Dated { get; set; }
        public string InNumber { get; set; }
        //public bool IsManyAddressees { get; set; }
        //public string ManyAddresseesPlaceholder { get; set; }
        //public string ManyAddresseesLabel { get; set; }
        public IEmployees Addressee { get; set; }
        //public IEmployees Assignee { get; set; }
        public IBusinessUnits BusinessUnit { get; set; }
        public ICounterparties Correspondent { get; set; }
        //public IEmployees ResponsibleForReturnEmployee { get; set; }
        public IMailDeliveryMethods DeliveryMethod { get; set; }
    }
}
