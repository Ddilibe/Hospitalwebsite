using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomReservations.RoomReservationDetailsRow;

namespace SmartERP.RoomReservations
{
    public interface IRoomReservationDetailsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomReservationDetailsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoomReservationDetailsDeleteHandler
    {
        public RoomReservationDetailsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}