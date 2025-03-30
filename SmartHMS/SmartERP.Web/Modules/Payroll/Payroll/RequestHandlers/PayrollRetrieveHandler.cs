using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.Payroll.PayrollRow>;
using MyRow = SmartERP.Payroll.PayrollRow;

namespace SmartERP.Payroll
{
    public interface IPayrollRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PayrollRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPayrollRetrieveHandler
    {
        public PayrollRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}