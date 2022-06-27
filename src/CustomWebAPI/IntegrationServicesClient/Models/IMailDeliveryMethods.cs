namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Способы доставки")]
    class IMailDeliveryMethods
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public string Sid { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
    }
}
