using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomSettings.BedTypesRow>;
using MyRow = SmartERP.RoomSettings.BedTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IBedTypesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BedTypesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBedTypesRetrieveHandler
    {
        public BedTypesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}