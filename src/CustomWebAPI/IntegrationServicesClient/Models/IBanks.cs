namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Банк")]
    public  class IBanks : ICounterparties
    {
        //public string Name { get; set; }
        //public string TIN { get; set; }
        //public string LegalAddress { get; set; }
        //public string PostalAddress { get; set; }
        //public string Phones { get; set; }
        //public string Email { get; set; }
        //public string Homepage { get; set; }
        //public string Note { get; set; }
        //public string Nonresident { get; set; }
        //public string PSRN { get; set; }
        //public string NCEO { get; set; }
        //public string NCEA { get; set; }
        //public string Account { get; set; }
        //public string CanExchange { get; set; }
        //public string Code { get; set; }
        //public string Status { get; set; }
        //public int Id { get; set; }
        public string TRRC { get; set; }
        public string IsCardReadOnly { get; set; }
        public string LegalName { get; set; }
        public string BIC { get; set; }
        public string CorrespondentAccount { get; set; }
        public bool IsSystem { get; set; }
    }
}
