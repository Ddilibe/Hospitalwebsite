using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomReservations.Forms
{
    [FormScript("RoomReservations.RoomReservations")]
    [BasedOnRow(typeof(RoomReservationsRow), CheckNames = true)]
    public class RoomReservationsForm
    {
        //public Int64 CustomerId { get; set; }
        //public DateTime CheckIn { get; set; }
        //public DateTime CheckOut { get; set; }
        //public String ArivalFrom { get; set; }
        //public Int64 BookingTypeId { get; set; }
        //public Int64 BookingReferenceId { get; set; }
        //public String ChooseBookingReference { get; set; }
        //public String PurposeOfVisit { get; set; }
        //public String Remarks { get; set; }
        //public Double BookingCharge { get; set; }
        //public Double Tax { get; set; }
        //public Double ServiceCharge { get; set; }
        //public Double Total { get; set; }
        [QuarterWidth(UntilNext = true)]
        public long CustomerId { get; set; }
        [DefaultValue("now")]
        public DateTime CheckIn { get; set; }
        [DefaultValue("now")]
        public DateTime CheckOut { get; set; }
        public string ArivalFrom { get; set; }
        public long BookingTypeId { get; set; }
        public long BookingReferenceId { get; set; }
        public string ChooseBookingReference { get; set; }
        public string PurposeOfVisit { get; set; }
        [RoomReservationDetailsEditor]
        [FullWidth]
        public List<RoomReservationDetailsRow> RoomList { get; set; }
        [HalfWidth(UntilNext = true)]
        [ReadOnly(true)]
        public double BookingCharge { get; set; }
        [ReadOnly(true)]
        public double Tax { get; set; }
        [ReadOnly(true)]
        public double ServiceCharge { get; set; }
        [ReadOnly(true)]
        public double Total { get; set; }
        [FullWidth]
        [TextAreaEditor(Cols =1,Rows =3)]
        public string Remarks { get; set; }
    }
}