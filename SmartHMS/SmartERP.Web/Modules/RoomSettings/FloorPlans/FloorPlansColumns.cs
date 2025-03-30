using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Columns
{
    [ColumnsScript("RoomSettings.FloorPlans")]
    [BasedOnRow(typeof(FloorPlansRow), CheckNames = true)]
    public class FloorPlansColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 Id { get; set; }
        public String FloorName { get; set; }
        public Int32 StartRoomNo { get; set; }
        public Int32 NoOfRoom { get; set; }
    }
}