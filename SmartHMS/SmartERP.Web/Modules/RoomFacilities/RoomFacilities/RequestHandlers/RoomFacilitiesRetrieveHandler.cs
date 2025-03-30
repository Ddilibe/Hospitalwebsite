using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomFacilities.RoomFacilitiesRow>;
using MyRow = SmartERP.RoomFacilities.RoomFacilitiesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomFacilitiesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomFacilitiesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomFacilitiesRetrieveHandler
    {
        public RoomFacilitiesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}