using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomSettings.BookingSorucesRow>;
using MyRow = SmartERP.RoomSettings.BookingSorucesRow;

namespace SmartERP.RoomSettings
{
    public interface IBookingSorucesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BookingSorucesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBookingSorucesListHandler
    {
        public BookingSorucesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}