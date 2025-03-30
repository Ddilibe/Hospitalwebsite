using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomReservations.RoomReservationDetailsRow>;
using MyRow = SmartERP.RoomReservations.RoomReservationDetailsRow;

namespace SmartERP.RoomReservations
{
    public interface IRoomReservationDetailsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomReservationDetailsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoomReservationDetailsListHandler
    {
        public RoomReservationDetailsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}