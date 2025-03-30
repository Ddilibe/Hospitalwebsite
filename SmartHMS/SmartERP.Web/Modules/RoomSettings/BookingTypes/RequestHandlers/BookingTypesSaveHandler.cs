using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomSettings.BookingTypesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomSettings.BookingTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IBookingTypesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BookingTypesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBookingTypesSaveHandler
    {
        public BookingTypesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}