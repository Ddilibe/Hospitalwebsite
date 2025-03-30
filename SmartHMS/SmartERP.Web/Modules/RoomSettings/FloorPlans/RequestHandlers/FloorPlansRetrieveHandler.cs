using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomSettings.FloorPlansRow>;
using MyRow = SmartERP.RoomSettings.FloorPlansRow;

namespace SmartERP.RoomSettings
{
    public interface IFloorPlansRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class FloorPlansRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IFloorPlansRetrieveHandler
    {
        public FloorPlansRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}