using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.Masters.IncomesRow>;
using MyRow = SmartERP.Masters.IncomesRow;

namespace SmartERP.Masters
{
    public interface IIncomesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class IncomesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IIncomesRetrieveHandler
    {
        public IncomesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}