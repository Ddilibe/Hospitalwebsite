using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomReservations.RoomReservationsRow>;
using MyRow = SmartERP.RoomReservations.RoomReservationsRow;

namespace SmartERP.RoomReservations
{
    public interface IRoomReservationsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomReservationsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoomReservationsListHandler
    {
        public RoomReservationsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}