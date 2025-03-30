using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomSettings.BookingTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IBookingTypesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class BookingTypesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBookingTypesDeleteHandler
    {
        public BookingTypesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}