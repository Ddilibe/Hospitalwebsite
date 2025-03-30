using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.Masters.DeductionsRow;

namespace SmartERP.Masters
{
    public interface IDeductionsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class DeductionsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDeductionsDeleteHandler
    {
        public DeductionsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}