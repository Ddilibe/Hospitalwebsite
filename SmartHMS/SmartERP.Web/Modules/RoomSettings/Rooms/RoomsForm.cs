using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Forms
{
    [FormScript("RoomSettings.Rooms")]
    [BasedOnRow(typeof(RoomsRow), CheckNames = true)]
    public class RoomsForm
    {
        [QuarterWidth(UntilNext =true)]
        public Int64 RoomTypeId { get; set; }
        public Int32 RoomNo { get; set; }
        public Int32 Capacity { get; set; }
        public Int32 ExtraCapability { get; set; }
        public Double Rate { get; set; }
        public Double BedCharge { get; set; }
        public Double PersonCharge { get; set; }
        [FormCssClass("line-break-sm")]
        [QuarterWidth(UntilNext = true)]
        public Int32 RoomSize { get; set; }
        public Int64 RoomSizeType { get; set; }
        public Int32 BedNo { get; set; }
        public Int64 BedType { get; set; }
        [TextAreaEditor(Cols =1,Rows =3)]
        [FullWidth]
        public String RoomDrescription { get; set; }
        [TextAreaEditor(Cols = 1, Rows = 3)]
        [FullWidth]
        public String ReserveCondition { get; set; }
    }
}