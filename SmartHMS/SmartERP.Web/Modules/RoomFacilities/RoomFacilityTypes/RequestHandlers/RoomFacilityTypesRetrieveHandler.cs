using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomFacilities.RoomFacilityTypesRow>;
using MyRow = SmartERP.RoomFacilities.RoomFacilityTypesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomFacilityTypesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomFacilityTypesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomFacilityTypesRetrieveHandler
    {
        public RoomFacilityTypesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}