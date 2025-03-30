using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomSettings.RoomTypesRow>;
using MyRow = SmartERP.RoomSettings.RoomTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomTypesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomTypesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoomTypesListHandler
    {
        public RoomTypesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}