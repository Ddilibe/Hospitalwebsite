using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomFacilities.RoomFacilitiesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomFacilities.RoomFacilitiesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomFacilitiesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomFacilitiesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomFacilitiesSaveHandler
    {
        public RoomFacilitiesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}