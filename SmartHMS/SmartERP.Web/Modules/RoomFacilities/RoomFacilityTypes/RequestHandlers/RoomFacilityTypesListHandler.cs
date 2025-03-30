using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomFacilities.RoomFacilityTypesRow>;
using MyRow = SmartERP.RoomFacilities.RoomFacilityTypesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomFacilityTypesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomFacilityTypesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoomFacilityTypesListHandler
    {
        public RoomFacilityTypesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}