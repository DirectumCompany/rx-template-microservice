﻿namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Журналы регистрации")]
    public class IDocumentRegisters
    {
        public string Name { get; set; }
        public string Index { get; set; }
        public int NumberOfDigitsInNumber { get; set; }
        public string ValueExample { get; set; }
        public string DisplayName { get; set; }
        public string DocumentFlow { get; set; }
        public string RegisterType { get; set; }
        public string NumberingPeriod { get; set; }
        public string NumberingSection { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
        public IRegistrationGroups RegistrationGroup { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
