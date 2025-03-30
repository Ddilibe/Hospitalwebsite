using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomSettings.RoomTypesRow>;
using MyRow = SmartERP.RoomSettings.RoomTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomTypesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomTypesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomTypesRetrieveHandler
    {
        public RoomTypesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}