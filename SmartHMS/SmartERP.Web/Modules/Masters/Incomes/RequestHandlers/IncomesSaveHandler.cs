using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.Masters.IncomesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.Masters.IncomesRow;

namespace SmartERP.Masters
{
    public interface IIncomesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class IncomesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IIncomesSaveHandler
    {
        public IncomesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}