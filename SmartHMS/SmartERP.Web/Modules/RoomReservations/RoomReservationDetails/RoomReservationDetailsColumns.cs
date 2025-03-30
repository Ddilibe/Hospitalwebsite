using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomReservations.Columns
{
    [ColumnsScript("RoomReservations.RoomReservationDetails")]
    [BasedOnRow(typeof(RoomReservationDetailsRow), CheckNames = true)]
    public class RoomReservationDetailsColumns
    {
    //    [EditLink, DisplayName("Db.Shared.RecordId")]
    //    public Int64 Id { get; set; }
    //    public String RoomReservationArivalFrom { get; set; }
    //    public String RoomType { get; set; }
    //    public String RoomNoRoomDrescription { get; set; }
    //    public Int32 Adults { get; set; }
    //    public Int32 Children { get; set; }
    //    public DateTime CheckIn { get; set; }
    //    public DateTime CheckOut { get; set; }
    //    public Double Rent { get; set; }
     [EditLink, DisplayName("Db.Shared.RecordId")]
    public long Id { get; set; }
    [EditLink]
    public int RoomRoomNo { get; set; }
    public String RoomTypeBookingSoruce { get; set; }
    public int Adults { get; set; }
    public int Children { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public double Rent { get; set; }
    
    }
}