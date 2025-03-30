using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomFacilities.Columns
{
    [ColumnsScript("RoomFacilities.RoomFacilityTypes")]
    [BasedOnRow(typeof(RoomFacilityTypesRow), CheckNames = true)]
    public class RoomFacilityTypesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId")]
        public Int64 Id { get; set; }
        [EditLink]
        public String Name { get; set; }
    }
}