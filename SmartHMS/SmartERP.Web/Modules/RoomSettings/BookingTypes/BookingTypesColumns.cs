using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Columns
{
    [ColumnsScript("RoomSettings.BookingTypes")]
    [BasedOnRow(typeof(BookingTypesRow), CheckNames = true)]
    public class BookingTypesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 Id { get; set; }
        [EditLink]
        public String BookingType { get; set; }
    }
}