using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.Payroll.Forms
{
    [FormScript("Payroll.Payroll")]
    [BasedOnRow(typeof(PayrollRow), CheckNames = true)]
    public class PayrollForm
    {
        [QuarterWidth]
        public String Number { get; set; }
       
        [QuarterWidth]
        [DefaultValue("now")]
        public DateTime PaymentDate { get; set; }
        [QuarterWidth]
        public Int32 CashBankId { get; set; }
        [FullWidth]
        public String Description { get; set; }
        [Category("Payroll")]
        [PayrollDetailEditor]
        public List<PayrollDetailRow> ItemList { get; set; }
        [Category("Summary")]
        [QuarterWidth(UntilNext =true)]
        public String CurrencyName { get; set; }
        public Double TotalBasicSalary { get; set; }
        public Double TotalIncome { get; set; }
        public Double TotalDeduction { get; set; }
        public Double TotalTakeHomePay { get; set; }
        public Double TotalPaymentAmount { get; set; }
    }
}