using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomFacilities.RoomFacilitiesRow;

namespace SmartERP.RoomFacilities
{
    public interface IRoomFacilitiesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomFacilitiesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoomFacilitiesDeleteHandler
    {
        public RoomFacilitiesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}