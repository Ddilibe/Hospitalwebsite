using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomSettings.RoomTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomTypesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomTypesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoomTypesDeleteHandler
    {
        public RoomTypesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}