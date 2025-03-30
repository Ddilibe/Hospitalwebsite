using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomFacilities.Columns
{
    [ColumnsScript("RoomFacilities.RoomFacilities")]
    [BasedOnRow(typeof(RoomFacilitiesRow), CheckNames = true)]
    public class RoomFacilitiesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId")]
        public Int64 Id { get; set; }
        public String FacilityTypeName { get; set; }
        [EditLink]
        public String FacilityName { get; set; }
        public String Image { get; set; }
    }
}