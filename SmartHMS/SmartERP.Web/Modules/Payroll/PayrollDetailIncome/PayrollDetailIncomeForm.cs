using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.Payroll.Forms
{
    [FormScript("Payroll.PayrollDetailIncome")]
    [BasedOnRow(typeof(PayrollDetailIncomeRow), CheckNames = true)]
    public class PayrollDetailIncomeForm
    {
      
        public Int64 IncomeId { get; set; }
        public String ShortNote { get; set; }
        public Double Amount { get; set; }
    }
}