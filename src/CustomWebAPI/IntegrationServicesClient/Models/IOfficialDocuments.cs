using System;

namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Официальный документ")]
    public class IOfficialDocuments : IElectronicDocuments
    {
        public string RegistrationNumber { get; set; }
        //public int Index { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        //public string PlacedToCaseFileDate { get; set; }
        //public bool IsReturnRequired { get; set; }
        //public bool IsHeldByCounterParty { get; set; }
        //public string ReturnDeadline { get; set; }
        //public string ReturnDate { get; set; }
        //public string ScheduledReturnDateFromCounterparty { get; set; }
        public string Subject { get; set; }
        public string Note { get; set; }
        public DateTimeOffset DocumentDate { get; set; }
        //public string LocationState { get; set; }
        public string LifeCycleState { get; set; }
        public string RegistrationState { get; set; }
        //public string InternalApprovalState { get; set; }
        //public string ExternalApprovalState { get; set; }
        //public string ExecutionState { get; set; }
        //public string ControlExecutionState { get; set; }
        //public string ExchangeState { get; set; }
        //public string VerificationState { get; set; }
        public IDocumentRegisters DocumentRegister { get; set; }
        public IDocumentKinds DocumentKind { get; set; }
        public IOfficialDocuments LeadingDocument { get; set; }
        public IDocumentGroupBases DocumentGroup { get; set; }
        public IDepartments Department { get; set; }
        public IEmployees DeliveredTo { get; set; }
        public IEmployees OurSignatory { get; set; }
        public IEmployees PreparedBy { get; set; }
    }
}
