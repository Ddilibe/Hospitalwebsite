using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Forms
{
    [FormScript("RoomSettings.BedTypes")]
    [BasedOnRow(typeof(BedTypesRow), CheckNames = true)]
    public class BedTypesForm
    {
        public String Name { get; set; }
    }
}