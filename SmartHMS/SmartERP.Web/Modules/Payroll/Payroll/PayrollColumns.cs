using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.Payroll.Columns
{
    [ColumnsScript("Payroll.Payroll")]
    [BasedOnRow(typeof(PayrollRow), CheckNames = true)]
    public class PayrollColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 Id { get; set; }
        [EditLink]
        public String Number { get; set; }
        public String Description { get; set; }
        public DateTime PaymentDate { get; set; }
        public String CashBankName { get; set; }
        public String CurrencyName { get; set; }
        public Double TotalBasicSalary { get; set; }
        public Double TotalIncome { get; set; }
        public Double TotalDeduction { get; set; }
        public Double TotalTakeHomePay { get; set; }
        public Double TotalPaymentAmount { get; set; }
    }
}