using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Columns
{
    [ColumnsScript("RoomSettings.BookingSoruces")]
    [BasedOnRow(typeof(BookingSorucesRow), CheckNames = true)]
    public class BookingSorucesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 Id { get; set; }
        public String BookingType { get; set; }
        [EditLink]
        public String BookingSoruce { get; set; }
        public Double CommissionRate { get; set; }
    }
}