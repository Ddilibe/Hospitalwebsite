using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomReservations.RoomReservationDetailsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomReservations.RoomReservationDetailsRow;

namespace SmartERP.RoomReservations
{
    public interface IRoomReservationDetailsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomReservationDetailsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomReservationDetailsSaveHandler
    {
        public RoomReservationDetailsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}