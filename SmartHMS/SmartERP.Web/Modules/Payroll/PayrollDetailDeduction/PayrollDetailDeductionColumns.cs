using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.Payroll.Columns
{
    [ColumnsScript("Payroll.PayrollDetailDeduction")]
    [BasedOnRow(typeof(PayrollDetailDeductionRow), CheckNames = true)]
    public class PayrollDetailDeductionColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Int64 Id { get; set; }
        //public Int32 PayrollDetailId { get; set; }
        [EditLink]
        public String DeductionName { get; set; }
       
        public String ShortNote { get; set; }
        public Double Amount { get; set; }
    }
}