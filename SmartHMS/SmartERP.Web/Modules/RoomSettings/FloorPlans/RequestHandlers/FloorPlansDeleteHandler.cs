using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomSettings.FloorPlansRow;

namespace SmartERP.RoomSettings
{
    public interface IFloorPlansDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class FloorPlansDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IFloorPlansDeleteHandler
    {
        public FloorPlansDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}