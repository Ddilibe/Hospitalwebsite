using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.Masters.IncomesRow;

namespace SmartERP.Masters
{
    public interface IIncomesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class IncomesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IIncomesDeleteHandler
    {
        public IncomesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}