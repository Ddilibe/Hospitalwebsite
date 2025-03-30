using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.Masters.DeductionsRow>;
using MyRow = SmartERP.Masters.DeductionsRow;

namespace SmartERP.Masters
{
    public interface IDeductionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class DeductionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDeductionsListHandler
    {
        public DeductionsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}