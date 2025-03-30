using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.Payroll.Columns
{
    [ColumnsScript("Payroll.PayrollDetailIncome")]
    [BasedOnRow(typeof(PayrollDetailIncomeRow), CheckNames = true)]
    public class PayrollDetailIncomeColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Int64 Id { get; set; }
        [EditLink]
        public String IncomeName { get; set; }
        //[EditLink]
        public String ShortNote { get; set; }
        public Double Amount { get; set; }
    }
}