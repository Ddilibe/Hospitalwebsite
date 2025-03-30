using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomSettings.BookingSorucesRow;

namespace SmartERP.RoomSettings
{
    public interface IBookingSorucesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class BookingSorucesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBookingSorucesDeleteHandler
    {
        public BookingSorucesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}