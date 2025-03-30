using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.Payroll.PayrollDetailRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.Payroll.PayrollDetailRow;

namespace SmartERP.Payroll
{
    public interface IPayrollDetailSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PayrollDetailSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPayrollDetailSaveHandler
    {
        public PayrollDetailSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}