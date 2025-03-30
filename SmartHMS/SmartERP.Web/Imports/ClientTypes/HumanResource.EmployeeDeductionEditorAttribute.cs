using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SmartERP.HumanResource
{
    public partial class EmployeeDeductionEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SmartERP.HumanResource.EmployeeDeductionEditor";

        public EmployeeDeductionEditorAttribute()
            : base(Key)
        {
        }
    }
}
