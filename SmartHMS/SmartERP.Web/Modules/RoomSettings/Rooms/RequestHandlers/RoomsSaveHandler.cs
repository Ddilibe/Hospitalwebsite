using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomSettings.RoomsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomSettings.RoomsRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomsSaveHandler
    {
        public RoomsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}