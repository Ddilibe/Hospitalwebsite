﻿
namespace SmartERP.Quotations.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Quotations.QuotationDetails")]
    [BasedOnRow(typeof(Entities.QuotationDetailsRow), CheckNames = true)]
    public class QuotationDetailsColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Int64 Id { get; set; }
        [EditLink]
        public String ProductName { get; set; }
       
        public String Description { get; set; }
        public String UnitName { get; set; }
        public Double Quantity { get; set; }
        public Double UnitPrice { get; set; }
        public Double Discount { get; set; }
        public Double Total { get; set; }
        //public String QuotationDetails { get; set; }
    }
}