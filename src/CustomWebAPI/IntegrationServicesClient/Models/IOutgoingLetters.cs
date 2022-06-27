namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Исходящее письмо")]
    class IOutgoingLetters : IOfficialDocuments
    {
        public bool IsManyAddressees { get; set; }
        public IEmployees Addressee { get; set; }
        public IEmployees Assignee { get; set; }
        public IBusinessUnits BusinessUnit { get; set; }
        public ICounterparties Correspondent { get; set; }
        public IEmployees ResponsibleForReturnEmployee { get; set; }
        public IMailDeliveryMethods DeliveryMethod { get; set; }
    }
}
