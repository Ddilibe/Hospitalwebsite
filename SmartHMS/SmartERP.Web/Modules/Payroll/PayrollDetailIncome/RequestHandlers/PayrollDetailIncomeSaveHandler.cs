using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.Payroll.PayrollDetailIncomeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.Payroll.PayrollDetailIncomeRow;

namespace SmartERP.Payroll
{
    public interface IPayrollDetailIncomeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PayrollDetailIncomeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPayrollDetailIncomeSaveHandler
    {
        public PayrollDetailIncomeSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}