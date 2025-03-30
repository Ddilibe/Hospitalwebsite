using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomSettings.FloorsRow>;
using MyRow = SmartERP.RoomSettings.FloorsRow;

namespace SmartERP.RoomSettings
{
    public interface IFloorsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class FloorsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IFloorsRetrieveHandler
    {
        public FloorsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}