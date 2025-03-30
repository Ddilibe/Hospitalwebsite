using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.Payroll.PayrollDetailDeductionRow>;
using MyRow = SmartERP.Payroll.PayrollDetailDeductionRow;

namespace SmartERP.Payroll
{
    public interface IPayrollDetailDeductionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PayrollDetailDeductionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPayrollDetailDeductionRetrieveHandler
    {
        public PayrollDetailDeductionRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}