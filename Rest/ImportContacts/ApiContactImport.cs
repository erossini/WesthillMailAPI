using System;

namespace WesthillMail.ImportContacts
{
    internal class ApiContactImport
    {
        public Guid Id { get; set; }

        public ApiContactImportStatuses Status { get; set; }
    }
}
