using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.Masters.DeductionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.Masters.DeductionsRow;

namespace SmartERP.Masters
{
    public interface IDeductionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class DeductionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDeductionsSaveHandler
    {
        public DeductionsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}