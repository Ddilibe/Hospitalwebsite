using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomReservations.Forms
{
    [FormScript("RoomReservations.RoomReservationDetails")]
    [BasedOnRow(typeof(RoomReservationDetailsRow), CheckNames = true)]
    public class RoomReservationDetailsForm
    {
        //public Int64 RoomReservationId { get; set; }
        public Int64 RoomTypeId { get; set; }
        public Int64 RoomNoId { get; set; }
        public Int32 Adults { get; set; }
        public Int32 Children { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Double Rent { get; set; }
    }
}