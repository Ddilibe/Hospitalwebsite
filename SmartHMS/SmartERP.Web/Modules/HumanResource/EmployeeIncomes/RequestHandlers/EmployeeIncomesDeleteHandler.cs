using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.HumanResource.EmployeeIncomesRow;

namespace SmartERP.HumanResource
{
    public interface IEmployeeIncomesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class EmployeeIncomesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeIncomesDeleteHandler
    {
        public EmployeeIncomesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}