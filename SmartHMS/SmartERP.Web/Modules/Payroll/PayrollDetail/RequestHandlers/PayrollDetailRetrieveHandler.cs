using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.Payroll.PayrollDetailRow>;
using MyRow = SmartERP.Payroll.PayrollDetailRow;

namespace SmartERP.Payroll
{
    public interface IPayrollDetailRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PayrollDetailRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPayrollDetailRetrieveHandler
    {
        public PayrollDetailRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}