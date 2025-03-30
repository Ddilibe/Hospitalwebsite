using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomSettings.BookingSorucesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomSettings.BookingSorucesRow;

namespace SmartERP.RoomSettings
{
    public interface IBookingSorucesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BookingSorucesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBookingSorucesSaveHandler
    {
        public BookingSorucesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}