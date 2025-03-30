using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomFacilities.RoomFacilitiesRow>;
using MyRow = SmartERP.RoomFacilities.RoomFacilitiesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomFacilitiesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomFacilitiesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoomFacilitiesListHandler
    {
        public RoomFacilitiesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}