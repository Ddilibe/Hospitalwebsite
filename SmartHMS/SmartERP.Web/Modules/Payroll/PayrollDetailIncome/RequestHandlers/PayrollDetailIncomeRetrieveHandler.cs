using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.Payroll.PayrollDetailIncomeRow>;
using MyRow = SmartERP.Payroll.PayrollDetailIncomeRow;

namespace SmartERP.Payroll
{
    public interface IPayrollDetailIncomeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PayrollDetailIncomeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPayrollDetailIncomeRetrieveHandler
    {
        public PayrollDetailIncomeRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}