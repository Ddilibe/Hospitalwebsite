using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Reporting;
using SmartERP.Administration.Entities;
using SmartERP.Payroll;
using System;
using System.Collections.Generic;

namespace SmartERP.HumanResource
{
    [Report("PayrollDetailPrint")]
    [ReportDesign(MVC.Views.Payroll.PayrollDetail.PayrollDetailPrint)]
    [RequiredPermission(SmartERP.HumanResource.PermissionKeys.Payroll.View)]
    //[ReadPermission(SmartERP.HumanResource.PermissionKeys.Payroll.View)]
    public class PayrollDetailPrintModel : IReport, ICustomizeHtmlToPdf
    {
        public PayrollDetailPrintModel(ISqlConnections sqlConnections)
        {
            SqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));
        }

        public int Id { get; set; }

        protected ISqlConnections SqlConnections { get; }

        public object GetData()
        {
            var data = new PayrollDetailPrintData();

            using (var connection = SqlConnections.NewFor<PayrollDetailRow>())
            {
                var h = PayrollDetailRow.Fields;
                data.Header = connection.TryById<PayrollDetailRow>(Id, q => q
                     .SelectTableFields()
                     .Select(h.EmployeeFullName));
                

                var i = PayrollDetailIncomeRow.Fields;
                data.Incomes = connection.List<PayrollDetailIncomeRow>(q => q
                    .SelectTableFields()
                    .Select(i.IncomeName)
                    .Where(i.PayrollDetailId == Id));

                var d = PayrollDetailDeductionRow.Fields;
                data.Deductions = connection.List<PayrollDetailDeductionRow>(q => q
                    .SelectTableFields()
                    .Select(d.DeductionName)
                    .Where(d.PayrollDetailId == Id));

                var s = SmartERP.Administration.Entities.CompaniesRow.Fields;
                data.Company = connection.TryFirst<SmartERP.Administration.Entities.CompaniesRow>(q => q.SelectTableFields().Select(s.CurrencyCurrencySymbol).Select(s.CurrencyCurrencyName).Where(s.Id > 0)) ?? new SmartERP.Administration.Entities.CompaniesRow();

                
            }

            return data;
        }

        public void Customize(IHtmlToPdfOptions options)
        {
        }
    }

    public class PayrollDetailPrintData
    {
        public PayrollDetailRow Header { get; set; }
        public List<PayrollDetailIncomeRow> Incomes { get; set; }
        public List<PayrollDetailDeductionRow> Deductions { get; set; }
        public Administration.Entities.CompaniesRow Company { get; set; }
    }
}
