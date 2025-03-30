using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.Masters.Forms
{
    [FormScript("Masters.Deductions")]
    [BasedOnRow(typeof(DeductionsRow), CheckNames = true)]
    public class DeductionsForm
    {
        public String Name { get; set; }
        public String Description { get; set; }
    }
}