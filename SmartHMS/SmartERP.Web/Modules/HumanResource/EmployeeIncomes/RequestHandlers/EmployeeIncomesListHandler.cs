using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.HumanResource.EmployeeIncomesRow>;
using MyRow = SmartERP.HumanResource.EmployeeIncomesRow;

namespace SmartERP.HumanResource
{
    public interface IEmployeeIncomesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class EmployeeIncomesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeIncomesListHandler
    {
        public EmployeeIncomesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}