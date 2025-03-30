using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.HumanResource.EmployeeDeductionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.HumanResource.EmployeeDeductionsRow;

namespace SmartERP.HumanResource
{
    public interface IEmployeeDeductionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class EmployeeDeductionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeDeductionsSaveHandler
    {
        public EmployeeDeductionsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}