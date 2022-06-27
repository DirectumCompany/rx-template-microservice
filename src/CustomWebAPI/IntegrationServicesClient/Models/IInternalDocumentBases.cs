namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Внутренний документ")]
    class IInternalDocumentBases : IOfficialDocuments
    {
        public IEmployees Assignee { get; set; }
        public IBusinessUnits BusinessUnit { get; set; }
    }
}
