using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomFacilities.Forms
{
    [FormScript("RoomFacilities.RoomSizes")]
    [BasedOnRow(typeof(RoomSizesRow), CheckNames = true)]
    public class RoomSizesForm
    {
        public String Name { get; set; }
    }
}