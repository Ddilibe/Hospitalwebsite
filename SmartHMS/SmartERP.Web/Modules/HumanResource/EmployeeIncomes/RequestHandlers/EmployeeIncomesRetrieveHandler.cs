using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.HumanResource.EmployeeIncomesRow>;
using MyRow = SmartERP.HumanResource.EmployeeIncomesRow;

namespace SmartERP.HumanResource
{
    public interface IEmployeeIncomesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class EmployeeIncomesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeIncomesRetrieveHandler
    {
        public EmployeeIncomesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}