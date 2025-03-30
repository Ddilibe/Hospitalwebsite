using Serenity;
using Serenity.Data;
using Serenity.Extensions;
using Serenity.Services;
using SmartERP.HumanResource;
using SmartERP.HumanResource.Entities;
using System;
using Serenity.Net.Entity;
using System.Collections.Generic;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.Payroll.PayrollRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.Payroll.PayrollRow;

namespace SmartERP.Payroll
{
    public interface IPayrollSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PayrollSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPayrollSaveHandler
    {
        public PayrollSaveHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void BeforeSave()
        {
            base.BeforeSave();

            //AutoFillPayroll();

            //Row.TotalBasicSalary = 0;
            //Row.TotalIncome = 0;
            //Row.TotalDeduction = 0;
            //Row.TotalTakeHomePay = 0;
            //foreach (var item in Row.ItemList)
            //{
            //    Row.TotalBasicSalary += item.BasicSalary;
            //    Row.TotalIncome += item.TotalIncome;
            //    Row.TotalDeduction += item.TotalDeduction;
            //    Row.TotalTakeHomePay += item.TakeHomePay;
            //}


            if (Row.Number.Equals("Auto Generated"))
            {
                var connection = UnitOfWork.Connection;
                var request = new GetNextNumberRequest()
                {
                    Prefix = "Payroll/" + DateTime.Now.ToString("yyyyMM") + "/",
                    //Prefix = "SALARY/" + DateTime.Now.ToString("yyyyMM") + "/",
                    Length = 17
                };
                var respone = GetNextNumberHelper.GetNextNumber(connection, request, MyRow.Fields.Number);
                Row.Number = respone.Serial;
            }
        }

        //private void AutoFillPayroll()
        //{
        //    if (Row.Number.Equals("Auto Generated"))
        //    {
        //        var details = new List<PayrollDetailRow>();
        //        var emp = EmployeesRow.Fields;
        //        Row.TotalBasicSalary = 0;
        //        Row.TotalDeduction = 0;
        //        Row.TotalIncome = 0;
        //        //Row.TotalPaymentAmount = 0;
        //        Row.TotalTakeHomePay = 0;
        //        var employees = Connection.List<EmployeesRow>(x => x.SelectTableFields().Select(emp.PayrollBankName));
        //        foreach (var employee in employees)
        //        {
        //            var detail = new PayrollDetailRow();
        //            detail.EmployeeId = employee.Id;
        //            detail.BankAccount = employee.BankAccountForPayroll;
        //            detail.BankName = employee.PayrollBankName;
        //            detail.BasicSalary = employee.BasicSalary;
        //            Row.TotalBasicSalary += detail.BasicSalary;
        //            var ei = EmployeeIncomesRow.Fields;
        //            var incomes = Connection.List<EmployeeIncomesRow>(x => x.SelectTableFields().Where(ei.EmployeeId == employee.Id.Value));
        //            detail.IncomeList = new List<PayrollDetailIncomeRow>();
        //            double totalIncome = 0;
        //            foreach (var income in incomes)
        //            {
        //                detail.IncomeList.Add(new PayrollDetailIncomeRow()
        //                {
        //                    PayrollDetailId = detail.Id,
        //                    IncomeId = income.IncomeId,
        //                    Amount = income.Amount.Value
        //                });
        //                totalIncome += income.Amount.Value;
        //            }
        //            detail.TotalIncome = totalIncome;
        //            Row.TotalIncome += detail.TotalIncome;

        //            var ed = EmployeeDeductionsRow.Fields;
        //            var deductions = Connection.List<EmployeeDeductionsRow>(x => x.SelectTableFields().Where(ed.EmployeeId == employee.Id.Value));
        //            detail.DeductionList = new List<PayrollDetailDeductionRow>();
        //            double totalDeduction = 0;
        //            foreach (var deduction in deductions)
        //            {
        //                detail.DeductionList.Add(new PayrollDetailDeductionRow()
        //                {
        //                    PayrollDetailId = detail.Id,
        //                    DeductionId = deduction.DeductionId,
        //                    Amount = deduction.Amount.Value
        //                });
        //                totalDeduction += deduction.Amount.Value;
        //            }
        //            detail.TotalDeduction = totalDeduction;
        //            Row.TotalDeduction += detail.TotalDeduction;

        //            detail.TakeHomePay = detail.BasicSalary + detail.TotalIncome - detail.TotalDeduction;

        //            Row.TotalTakeHomePay += detail.TakeHomePay;

        //            details.Add(detail);
        //        }

        //        Row.ItemList = details;
        //    }
        //}
    }
}