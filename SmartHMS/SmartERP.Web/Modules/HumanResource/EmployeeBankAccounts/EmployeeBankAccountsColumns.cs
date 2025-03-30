
namespace SmartERP.HumanResource.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HumanResource.EmployeeBankAccounts")]
    [BasedOnRow(typeof(Entities.EmployeeBankAccountsRow), CheckNames = true)]
    public class EmployeeBankAccountsColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Int64 Id { get; set; }
        //public String EmployeeFirstName { get; set; }
        [EditLink]
        public String AccountTitle { get; set; }
        public String AccountNumber { get; set; }
        public String BankName1 { get; set; }
        public String BankCode { get; set; }
        public String BankBranch { get; set; }
    }
}