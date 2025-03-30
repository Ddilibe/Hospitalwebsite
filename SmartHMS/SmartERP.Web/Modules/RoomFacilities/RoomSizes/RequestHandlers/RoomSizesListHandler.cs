using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomFacilities.RoomSizesRow>;
using MyRow = SmartERP.RoomFacilities.RoomSizesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomSizesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomSizesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoomSizesListHandler
    {
        public RoomSizesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}