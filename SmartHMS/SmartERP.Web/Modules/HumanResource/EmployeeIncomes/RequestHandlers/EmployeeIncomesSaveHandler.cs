using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.HumanResource.EmployeeIncomesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.HumanResource.EmployeeIncomesRow;

namespace SmartERP.HumanResource
{
    public interface IEmployeeIncomesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class EmployeeIncomesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeIncomesSaveHandler
    {
        public EmployeeIncomesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}