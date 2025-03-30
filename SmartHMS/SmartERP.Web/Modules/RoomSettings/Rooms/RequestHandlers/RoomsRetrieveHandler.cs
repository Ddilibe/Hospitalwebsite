using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomSettings.RoomsRow>;
using MyRow = SmartERP.RoomSettings.RoomsRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomsRetrieveHandler
    {
        public RoomsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}