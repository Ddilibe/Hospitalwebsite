using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.Payroll.PayrollDetailDeductionRow>;
using MyRow = SmartERP.Payroll.PayrollDetailDeductionRow;

namespace SmartERP.Payroll
{
    public interface IPayrollDetailDeductionListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PayrollDetailDeductionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPayrollDetailDeductionListHandler
    {
        public PayrollDetailDeductionListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}