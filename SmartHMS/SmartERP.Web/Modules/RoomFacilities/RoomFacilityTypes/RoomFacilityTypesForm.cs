using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomFacilities.Forms
{
    [FormScript("RoomFacilities.RoomFacilityTypes")]
    [BasedOnRow(typeof(RoomFacilityTypesRow), CheckNames = true)]
    public class RoomFacilityTypesForm
    {
        public String Name { get; set; }
    }
}