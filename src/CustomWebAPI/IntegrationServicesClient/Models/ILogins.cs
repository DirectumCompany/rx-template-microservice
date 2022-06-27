namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Учетная запись")]
    public class ILogins : IRecipients
    {
        public int Id { get; set; }
        public bool? NeedChangePassword { get; set; }
        public string LoginName { get; set; }
        public string TypeAuthentication { get; set; }
        public string Status { get; set; }
    }
}
