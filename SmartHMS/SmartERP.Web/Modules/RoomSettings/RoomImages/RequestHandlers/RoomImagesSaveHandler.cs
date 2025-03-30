using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomSettings.RoomImagesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomSettings.RoomImagesRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomImagesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomImagesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomImagesSaveHandler
    {
        public RoomImagesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}