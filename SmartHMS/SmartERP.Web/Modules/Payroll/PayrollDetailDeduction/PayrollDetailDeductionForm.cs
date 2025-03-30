using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.Payroll.Forms
{
    [FormScript("Payroll.PayrollDetailDeduction")]
    [BasedOnRow(typeof(PayrollDetailDeductionRow), CheckNames = true)]
    public class PayrollDetailDeductionForm
    {
        
        public Int64 DeductionId { get; set; }
        public String ShortNote { get; set; }
        public Double Amount { get; set; }
    }
}