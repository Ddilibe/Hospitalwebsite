using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SmartERP.RoomReservations
{
    public partial class RoomReservationDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SmartERP.RoomReservations.RoomReservationDetailsEditor";

        public RoomReservationDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}
