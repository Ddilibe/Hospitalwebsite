using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SmartERP.HumanResource
{
    public partial class EmployeeIncomeEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SmartERP.HumanResource.EmployeeIncomeEditor";

        public EmployeeIncomeEditorAttribute()
            : base(Key)
        {
        }
    }
}
