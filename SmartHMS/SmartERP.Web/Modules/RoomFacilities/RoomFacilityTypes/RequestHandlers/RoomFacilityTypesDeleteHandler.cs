using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomFacilities.RoomFacilityTypesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomFacilityTypesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomFacilityTypesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoomFacilityTypesDeleteHandler
    {
        public RoomFacilityTypesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}