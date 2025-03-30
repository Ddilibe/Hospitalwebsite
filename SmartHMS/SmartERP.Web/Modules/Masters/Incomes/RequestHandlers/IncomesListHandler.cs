using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.Masters.IncomesRow>;
using MyRow = SmartERP.Masters.IncomesRow;

namespace SmartERP.Masters
{
    public interface IIncomesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class IncomesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IIncomesListHandler
    {
        public IncomesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}