using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomReservations.RoomReservationsRow>;
using MyRow = SmartERP.RoomReservations.RoomReservationsRow;

namespace SmartERP.RoomReservations
{
    public interface IRoomReservationsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomReservationsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomReservationsRetrieveHandler
    {
        public RoomReservationsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}