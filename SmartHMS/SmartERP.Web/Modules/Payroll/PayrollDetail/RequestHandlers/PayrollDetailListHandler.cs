using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.Payroll.PayrollDetailRow>;
using MyRow = SmartERP.Payroll.PayrollDetailRow;

namespace SmartERP.Payroll
{
    public interface IPayrollDetailListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PayrollDetailListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPayrollDetailListHandler
    {
        public PayrollDetailListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}