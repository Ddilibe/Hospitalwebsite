using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomSettings.RoomImagesRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomImagesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomImagesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoomImagesDeleteHandler
    {
        public RoomImagesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}