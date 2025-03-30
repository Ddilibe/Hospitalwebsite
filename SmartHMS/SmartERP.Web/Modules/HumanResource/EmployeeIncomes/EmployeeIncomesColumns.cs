using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.HumanResource.Columns
{
    [ColumnsScript("HumanResource.EmployeeIncomes")]
    [BasedOnRow(typeof(EmployeeIncomesRow), CheckNames = true)]
    public class EmployeeIncomesColumns
    {
        [EditLink]
        public String IncomeName { get; set; }
        public DateTime Amount { get; set; }
        public String Description { get; set; }
       
    }
}