using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomSettings.ComplementariesRow>;
using MyRow = SmartERP.RoomSettings.ComplementariesRow;

namespace SmartERP.RoomSettings
{
    public interface IComplementariesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ComplementariesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IComplementariesRetrieveHandler
    {
        public ComplementariesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}