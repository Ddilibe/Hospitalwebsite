using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomSettings.FloorPlansRow>;
using MyRow = SmartERP.RoomSettings.FloorPlansRow;

namespace SmartERP.RoomSettings
{
    public interface IFloorPlansListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class FloorPlansListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IFloorPlansListHandler
    {
        public FloorPlansListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}