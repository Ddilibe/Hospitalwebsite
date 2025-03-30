using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.Payroll.Columns
{
    [ColumnsScript("Payroll.PayrollDetail")]
    [BasedOnRow(typeof(PayrollDetailRow), CheckNames = true)]
    public class PayrollDetailColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Int64 Id { get; set; }
        //public Int32 PayrollId { get; set; }
        [EditLink]
        public String EmployeeFullName { get; set; }
       
        public String BankAccount { get; set; }
        public String BankName { get; set; }
        public Double BasicSalary { get; set; }
        public Double TotalIncome { get; set; }
        public Double TotalDeduction { get; set; }
        public Double TakeHomePay { get; set; }
    }
}