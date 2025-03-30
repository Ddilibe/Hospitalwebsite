using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Forms
{
    [FormScript("RoomSettings.BookingSoruces")]
    [BasedOnRow(typeof(BookingSorucesRow), CheckNames = true)]
    public class BookingSorucesForm
    {
        public Int64 BookingTypeId { get; set; }
        public String BookingSoruce { get; set; }
        public Double CommissionRate { get; set; }
    }
}