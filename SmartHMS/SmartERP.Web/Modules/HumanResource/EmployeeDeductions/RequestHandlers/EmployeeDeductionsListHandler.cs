using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.HumanResource.EmployeeDeductionsRow>;
using MyRow = SmartERP.HumanResource.EmployeeDeductionsRow;

namespace SmartERP.HumanResource
{
    public interface IEmployeeDeductionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class EmployeeDeductionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeDeductionsListHandler
    {
        public EmployeeDeductionsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}