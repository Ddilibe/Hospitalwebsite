using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomSettings.FloorPlansRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomSettings.FloorPlansRow;

namespace SmartERP.RoomSettings
{
    public interface IFloorPlansSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class FloorPlansSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IFloorPlansSaveHandler
    {
        public FloorPlansSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}