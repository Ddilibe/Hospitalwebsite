using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.HumanResource.Columns
{
    [ColumnsScript("HumanResource.EmployeeDeductions")]
    [BasedOnRow(typeof(EmployeeDeductionsRow), CheckNames = true)]
    public class EmployeeDeductionsColumns
    {
        [EditLink]
        public String DeductionName { get; set; }
        public DateTime Amount { get; set; }
       
        public String Description { get; set; }
       
    }
}