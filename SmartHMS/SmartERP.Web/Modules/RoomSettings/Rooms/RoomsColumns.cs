using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Columns
{
    [ColumnsScript("RoomSettings.Rooms")]
    [BasedOnRow(typeof(RoomsRow), CheckNames = true)]
    public class RoomsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 Id { get; set; }
        public String RoomType { get; set; }
        public Int32 RoomNo { get; set; }
        public Int32 Capacity { get; set; }
        public Int32 ExtraCapability { get; set; }
        public Double Rate { get; set; }
        public Double BedCharge { get; set; }
        public Double PersonCharge { get; set; }
        public Int32 RoomSize { get; set; }
        public String RoomSizeTypeName { get; set; }
        public Int32 BedNo { get; set; }
        public String BedTypeName { get; set; }
        [EditLink]
        public String RoomDrescription { get; set; }
        public String ReserveCondition { get; set; }
    }
}