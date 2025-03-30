using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomSettings.RoomTypesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomSettings.RoomTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomTypesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomTypesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomTypesSaveHandler
    {
        public RoomTypesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}