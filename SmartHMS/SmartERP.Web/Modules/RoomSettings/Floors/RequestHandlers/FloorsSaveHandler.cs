using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomSettings.FloorsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomSettings.FloorsRow;

namespace SmartERP.RoomSettings
{
    public interface IFloorsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class FloorsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IFloorsSaveHandler
    {
        public FloorsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}