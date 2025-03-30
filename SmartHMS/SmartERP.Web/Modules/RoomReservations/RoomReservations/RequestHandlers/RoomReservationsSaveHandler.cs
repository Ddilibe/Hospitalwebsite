using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomReservations.RoomReservationsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomReservations.RoomReservationsRow;

namespace SmartERP.RoomReservations
{
    public interface IRoomReservationsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomReservationsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomReservationsSaveHandler
    {
        public RoomReservationsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}