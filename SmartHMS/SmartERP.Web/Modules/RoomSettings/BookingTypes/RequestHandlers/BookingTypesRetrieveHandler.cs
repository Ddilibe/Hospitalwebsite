using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomSettings.BookingTypesRow>;
using MyRow = SmartERP.RoomSettings.BookingTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IBookingTypesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BookingTypesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBookingTypesRetrieveHandler
    {
        public BookingTypesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}