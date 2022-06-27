using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomWebAPI.IntegrationServicesClient.Models
{
    [EntityName("Электронный документ")]
    public class IElectronicDocuments
    {
        public string Name { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }
        public bool HasRelations { get; set; }
        public int LastVersionSignatureType { get; set; }
        public bool LastVersionApproved { get; set; }
        public bool HasVersions { get; set; }
        public bool HasPublicBody { get; set; }
        public bool VersionsLocked { get; set; }
        public int Id { get; set; }
        public IAssociatedApplications AssociatedApplication { get; set; }
        public IEnumerable<IElectronicDocumentVersionss> Versions { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public IElectronicDocumentVersionss LastVersion()
        {
            var lastVersions = Client.Instance().For<IElectronicDocuments>()
            .Key(Id)
            .Expand(x => x.Versions)
            .FindEntriesAsync()
            .Result.FirstOrDefault().Versions.LastOrDefault();

            var lastVersion = Client.Instance()
            .For<IElectronicDocuments>()
            .Key(Id)
            .NavigateTo(v => v.Versions)
            .Key(lastVersions.Id)
            //.Expand(v => v.ElectronicDocument)
            .Expand(v => v.Body)
            .FindEntriesAsync()
            .Result.LastOrDefault();

            return lastVersion;
        }

        public IElectronicDocumentVersionss CreateVersion(string nameVersion, IAssociatedApplications extention)
        {
            var documentVersion = Client.Instance().For<IElectronicDocuments>()
            .Key(this.Id)
            .NavigateTo(x => x.Versions)
            .Set(new IElectronicDocumentVersionss() { Note = nameVersion, Created = DateTime.Now, AssociatedApplication = extention })
            .InsertEntryAsync()
            .Result;

            if (documentVersion == null)
                return null;

            return documentVersion;
        }

        public bool FillBody(IElectronicDocumentVersionss version, string content = "")
        {
            byte[] encodingContent;

            if (version.Body.Value != null)
                encodingContent = version.Body.Value;
            else
                encodingContent = Convert.FromBase64String(Convert.ToBase64String(Encoding.Default.GetBytes(content)));

            var updatedVersion = Client.Instance().For<IElectronicDocuments>()
            .Key(this)
            .NavigateTo(x => x.Versions)
            .Key(version)
            .NavigateTo(v => v.Body)
            .Set(new { Value = encodingContent })
            .InsertEntryAsync()
            .Result;

            if (updatedVersion != null)
                return true;

            return false;
        }
    }
}
