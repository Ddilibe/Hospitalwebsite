using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Forms
{
    [FormScript("RoomSettings.FloorPlans")]
    [BasedOnRow(typeof(FloorPlansRow), CheckNames = true)]
    public class FloorPlansForm
    {
        public Int64 Floor { get; set; }
        public Int32 StartRoomNo { get; set; }
        public Int32 NoOfRoom { get; set; }
    }
}