using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomSettings.BookingTypesRow>;
using MyRow = SmartERP.RoomSettings.BookingTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IBookingTypesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BookingTypesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBookingTypesListHandler
    {
        public BookingTypesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}