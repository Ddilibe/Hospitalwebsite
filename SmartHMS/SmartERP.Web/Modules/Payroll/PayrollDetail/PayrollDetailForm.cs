using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.Payroll.Forms
{
    [FormScript("Payroll.PayrollDetail")]
    [BasedOnRow(typeof(PayrollDetailRow), CheckNames = true)]
    public class PayrollDetailForm
    {
        [Category("Employee Info")]
        public Int64 Id { get; set; }
        //public Int32 PayrollId { get; set; }
        [QuarterWidth]
        public Int64 EmployeeId { get; set; }
        [QuarterWidth]
        public String BankAccount { get; set; }
        [QuarterWidth]
        public String BankName { get; set; }
        [Category("Payroll Components")]

        public Double BasicSalary { get; set; }

        [PayrollDetailIncomeEditor]
        public List<PayrollDetailIncomeRow> IncomeList { get; set; }
        [PayrollDetailDeductionEditor]
        public List<PayrollDetailDeductionRow> DeductionList { get; set; }

        [Category("Summary")]
        public Double TotalIncome { get; set; }
        public Double TotalDeduction { get; set; }
        public Double TakeHomePay { get; set; }
    }
}