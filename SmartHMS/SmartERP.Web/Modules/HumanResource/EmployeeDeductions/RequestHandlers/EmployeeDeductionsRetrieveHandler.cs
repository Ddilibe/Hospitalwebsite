using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.HumanResource.EmployeeDeductionsRow>;
using MyRow = SmartERP.HumanResource.EmployeeDeductionsRow;

namespace SmartERP.HumanResource
{
    public interface IEmployeeDeductionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class EmployeeDeductionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEmployeeDeductionsRetrieveHandler
    {
        public EmployeeDeductionsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}