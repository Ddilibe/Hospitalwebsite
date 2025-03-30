using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomReservations.Columns
{
    [ColumnsScript("RoomReservations.RoomReservations")]
    [BasedOnRow(typeof(RoomReservationsRow), CheckNames = true)]
    public class RoomReservationsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 Id { get; set; }
        public String CustomerName { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        [EditLink]
        public String ArivalFrom { get; set; }
        public String BookingType { get; set; }
        public String BookingReferenceBookingSoruce { get; set; }
        public String ChooseBookingReference { get; set; }
        public String PurposeOfVisit { get; set; }
        public String Remarks { get; set; }
        public Double BookingCharge { get; set; }
        public Double Tax { get; set; }
        public Double ServiceCharge { get; set; }
        public Double Total { get; set; }
    }
}