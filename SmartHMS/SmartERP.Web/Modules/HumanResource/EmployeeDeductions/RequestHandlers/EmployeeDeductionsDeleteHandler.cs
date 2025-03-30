using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.HumanResource.EmployeeDeductionsRow;

namespace SmartERP.HumanResource
{
    public interface IEmployeeDeductionsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class EmployeeDeductionsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeDeductionsDeleteHandler
    {
        public EmployeeDeductionsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}