using System;

namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Договор")]
    class IContracts : IOfficialDocuments
    {
        public IEmployees Assignee { get; set; }
        public IBusinessUnits BusinessUnit { get; set; }
        public ICounterparties Counterparty { get; set; }
        public IEmployees ResponsibleEmployee { get; set; }
        public IEmployees ResponsibleForReturnEmployee { get; set; }
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTill { get; set; }
        public double TotalAmount { get; set; }
        public ICurrency Currency { get; set; }
    }
}
