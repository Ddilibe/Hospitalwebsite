using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomFacilities.RoomSizesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomSizesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomSizesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoomSizesDeleteHandler
    {
        public RoomSizesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}