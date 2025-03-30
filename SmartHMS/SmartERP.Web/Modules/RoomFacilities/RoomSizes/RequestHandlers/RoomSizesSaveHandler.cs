using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomFacilities.RoomSizesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomFacilities.RoomSizesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomSizesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomSizesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomSizesSaveHandler
    {
        public RoomSizesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}