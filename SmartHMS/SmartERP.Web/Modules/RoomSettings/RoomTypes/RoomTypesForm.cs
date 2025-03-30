using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Forms
{
    [FormScript("RoomSettings.RoomTypes")]
    [BasedOnRow(typeof(RoomTypesRow), CheckNames = true)]
    public class RoomTypesForm
    {
        public String RoomType { get; set; }
    }
}