using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomReservations.RoomReservationDetailsRow>;
using MyRow = SmartERP.RoomReservations.RoomReservationDetailsRow;

namespace SmartERP.RoomReservations
{
    public interface IRoomReservationDetailsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomReservationDetailsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomReservationDetailsRetrieveHandler
    {
        public RoomReservationDetailsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}