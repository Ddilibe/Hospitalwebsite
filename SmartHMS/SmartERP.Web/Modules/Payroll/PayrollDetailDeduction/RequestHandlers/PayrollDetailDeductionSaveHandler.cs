using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.Payroll.PayrollDetailDeductionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.Payroll.PayrollDetailDeductionRow;

namespace SmartERP.Payroll
{
    public interface IPayrollDetailDeductionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PayrollDetailDeductionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPayrollDetailDeductionSaveHandler
    {
        public PayrollDetailDeductionSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}