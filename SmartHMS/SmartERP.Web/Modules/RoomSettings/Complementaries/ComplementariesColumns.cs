using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Columns
{
    [ColumnsScript("RoomSettings.Complementaries")]
    [BasedOnRow(typeof(ComplementariesRow), CheckNames = true)]
    public class ComplementariesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 Id { get; set; }
        public String RoomType1 { get; set; }
        [EditLink]
        public String Complementary { get; set; }
        public Double Rate { get; set; }
    }
}