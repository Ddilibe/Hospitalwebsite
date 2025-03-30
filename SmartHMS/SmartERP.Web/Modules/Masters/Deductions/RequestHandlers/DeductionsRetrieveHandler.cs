using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.Masters.DeductionsRow>;
using MyRow = SmartERP.Masters.DeductionsRow;

namespace SmartERP.Masters
{
    public interface IDeductionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class DeductionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDeductionsRetrieveHandler
    {
        public DeductionsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}