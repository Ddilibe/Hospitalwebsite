using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomSettings.RoomsRow>;
using MyRow = SmartERP.RoomSettings.RoomsRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoomsListHandler
    {
        public RoomsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}