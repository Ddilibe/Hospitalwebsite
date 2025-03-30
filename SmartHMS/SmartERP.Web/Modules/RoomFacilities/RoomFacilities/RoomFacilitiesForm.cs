using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomFacilities.Forms
{
    [FormScript("RoomFacilities.RoomFacilities")]
    [BasedOnRow(typeof(RoomFacilitiesRow), CheckNames = true)]
    public class RoomFacilitiesForm
    {
        public Int64 FacilityType { get; set; }
        public String FacilityName { get; set; }
        public String Image { get; set; }
    }
}