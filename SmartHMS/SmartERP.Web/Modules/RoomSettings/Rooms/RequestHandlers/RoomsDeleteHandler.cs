using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomSettings.RoomsRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoomsDeleteHandler
    {
        public RoomsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}