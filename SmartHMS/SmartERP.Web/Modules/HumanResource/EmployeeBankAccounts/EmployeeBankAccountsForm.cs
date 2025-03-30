
namespace SmartERP.HumanResource.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HumanResource.EmployeeBankAccounts")]
    [BasedOnRow(typeof(Entities.EmployeeBankAccountsRow), CheckNames = true)]
    public class EmployeeBankAccountsForm
    {
        //public Int64 Employee { get; set; }
        public String AccountTitle { get; set; }
        public String AccountNumber { get; set; }
        public Int64 BankName { get; set; }
        public String BankCode { get; set; }
        public String BankBranch { get; set; }
    }
}