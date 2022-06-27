namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Группа регистрации")]
    public class IRegistrationGroups : IRecipients
    {
        public string Index { get; set; }
        public bool CanRegisterIncoming { get; set; }
        public bool CanRegisterOutgoing { get; set; }
        public bool CanRegisterInternal { get; set; }
        public bool CanRegisterContractual { get; set; }
    }
}
