using Serenity;
using Serenity.Abstractions;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.Payroll.PayrollRow>;
using MyRow = SmartERP.Payroll.PayrollRow;

namespace SmartERP.Payroll
{
    public interface IPayrollListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PayrollListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPayrollListHandler
    {
        private static MyRow.RowFields Fld => MyRow.Fields;
        private IUserRetrieveService UserRetriever { get; }
        public PayrollListHandler(IRequestContext context, IUserRetrieveService userRetriever) : base(context)
        {
            UserRetriever = userRetriever ?? throw new ArgumentNullException(nameof(userRetriever));

        }
        public PayrollListHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void OnBeforeExecuteQuery()
        {
            base.OnBeforeExecuteQuery();
            if (!Permissions.HasPermission(SmartERP.Administration.PermissionKeys.PayrollGroup))
            {
                UserDefinition user = User.GetUserDefinition<UserDefinition>(UserRetriever);
                Query.Where(Fld.Id == -1);
            }

        }
    }
}