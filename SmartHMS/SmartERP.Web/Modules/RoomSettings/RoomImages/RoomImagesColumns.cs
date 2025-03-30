using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Columns
{
    [ColumnsScript("RoomSettings.RoomImages")]
    [BasedOnRow(typeof(RoomImagesRow), CheckNames = true)]
    public class RoomImagesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 Id { get; set; }
        public String RoomType1 { get; set; }
        [EditLink]
        public String Image { get; set; }
    }
}