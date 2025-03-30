using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomFacilities.RoomSizesRow>;
using MyRow = SmartERP.RoomFacilities.RoomSizesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomSizesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomSizesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomSizesRetrieveHandler
    {
        public RoomSizesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}