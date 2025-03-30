using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.HumanResource.Forms
{
    [FormScript("HumanResource.EmployeeIncomes")]
    [BasedOnRow(typeof(EmployeeIncomesRow), CheckNames = true)]
    public class EmployeeIncomesForm
    {
       
        public Int64 IncomeId { get; set; }
        public Double Amount { get; set; }
        public String Description { get; set; }
       
    }
}