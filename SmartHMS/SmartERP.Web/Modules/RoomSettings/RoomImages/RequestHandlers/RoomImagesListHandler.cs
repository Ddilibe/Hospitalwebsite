using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomSettings.RoomImagesRow>;
using MyRow = SmartERP.RoomSettings.RoomImagesRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomImagesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomImagesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoomImagesListHandler
    {
        public RoomImagesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}