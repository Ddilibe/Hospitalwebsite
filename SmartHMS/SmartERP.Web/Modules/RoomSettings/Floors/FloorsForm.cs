using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Forms
{
    [FormScript("RoomSettings.Floors")]
    [BasedOnRow(typeof(FloorsRow), CheckNames = true)]
    public class FloorsForm
    {
        public String Name { get; set; }
    }
}