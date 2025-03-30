using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomFacilities.RoomFacilityTypesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomFacilities.RoomFacilityTypesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomFacilityTypesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomFacilityTypesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomFacilityTypesSaveHandler
    {
        public RoomFacilityTypesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}