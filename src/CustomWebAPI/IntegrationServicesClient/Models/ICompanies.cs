namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Организация")]
    public class ICompanies : ICounterparties
    {
        public string TRRC { get; set; }
        public bool IsCardReadOnly { get; set; }
        public string LegalName { get; set; }
        public ICompanies HeadCompany { get; set; }
    }
}
