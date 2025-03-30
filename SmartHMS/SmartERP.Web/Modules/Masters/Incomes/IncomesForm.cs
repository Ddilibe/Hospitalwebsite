using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.Masters.Forms
{
    [FormScript("Masters.Incomes")]
    [BasedOnRow(typeof(IncomesRow), CheckNames = true)]
    public class IncomesForm
    {
        public String Name { get; set; }
        public String Description { get; set; }
    }
}