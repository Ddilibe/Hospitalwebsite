using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Forms
{
    [FormScript("RoomSettings.BookingTypes")]
    [BasedOnRow(typeof(BookingTypesRow), CheckNames = true)]
    public class BookingTypesForm
    {
        public String BookingType { get; set; }
    }
}