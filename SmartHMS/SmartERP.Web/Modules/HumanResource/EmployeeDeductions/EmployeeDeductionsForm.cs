using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.HumanResource.Forms
{
    [FormScript("HumanResource.EmployeeDeductions")]
    [BasedOnRow(typeof(EmployeeDeductionsRow), CheckNames = true)]
    public class EmployeeDeductionsForm
    {       
        public Int64 DeductionId { get; set; }
       
        public Double Amount { get; set; }

        public String Description { get; set; }
    }
}