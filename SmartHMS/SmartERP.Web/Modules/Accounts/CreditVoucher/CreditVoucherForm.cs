﻿
namespace SmartERP.Accounts.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Accounts.CreditVoucher")]
    [BasedOnRow(typeof(Entities.CreditVoucherRow), CheckNames = true)]
    public class CreditVoucherForm
    {
        //public String VNo { get; set; }
        //public String Vtype { get; set; }
        [DefaultValue("now")]
        public DateTime VDate { get; set; }
        public Int64 CoaId { get; set; }
        //public String Coa { get; set; }
        public Int64 CreditAccountId { get; set; }
        [DisplayName("Amount"), DefaultValue(0)]
        public Double Debit { get; set; }
        [TextAreaEditor(Cols = 1, Rows = 3)]
        public String Remark { get; set; }
        //public Double Credit { get; set; }
        //public Boolean IsPosted { get; set; }
        //public Boolean IsAppove { get; set; }
        //public DateTime InsertDate { get; set; }
        //public Int32 InsertUserId { get; set; }
        //public DateTime UpdateDate { get; set; }
        //public Int32 UpdateUserId { get; set; }
    }
}