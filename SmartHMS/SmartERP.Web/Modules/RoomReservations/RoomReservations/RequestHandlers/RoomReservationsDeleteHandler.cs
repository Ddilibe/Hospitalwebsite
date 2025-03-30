using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomReservations.RoomReservationsRow;

namespace SmartERP.RoomReservations
{
    public interface IRoomReservationsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomReservationsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoomReservationsDeleteHandler
    {
        public RoomReservationsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}