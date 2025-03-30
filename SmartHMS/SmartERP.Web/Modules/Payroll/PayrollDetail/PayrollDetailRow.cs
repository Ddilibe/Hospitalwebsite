using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using SmartERP.HumanResource.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace SmartERP.Payroll
{
    [ConnectionKey("Default"), Module("Payroll"), TableName("[dbo].[PayrollDetail]")]
    [DisplayName("Payroll Detail"), InstanceName("Payroll Detail")]
    [ReadPermission(SmartERP.HumanResource.PermissionKeys.Payroll.View)]
    [InsertPermission(SmartERP.HumanResource.PermissionKeys.Payroll.Create)]
    [UpdatePermission(SmartERP.HumanResource.PermissionKeys.Payroll.Update)]
    [DeletePermission(SmartERP.HumanResource.PermissionKeys.Payroll.Delete)]
    public sealed class PayrollDetailRow : Row<PayrollDetailRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Payroll Id"), NotNull]
        public Int64? PayrollId
        {
            get => fields.PayrollId[this];
            set => fields.PayrollId[this] = value;
        }

        [DisplayName("Employee"), NotNull, ForeignKey("[dbo].[Employees]", "Id"), LeftJoin("jEmployee"), TextualField("EmployeeFullName")]
        [LookupEditor(typeof(EmployeesRow))]
        public Int64? EmployeeId
        {
            get => fields.EmployeeId[this];
            set => fields.EmployeeId[this] = value;
        }

        [DisplayName("Bank Account"), Size(200), NotNull, QuickSearch, NameProperty]
        public String BankAccount
        {
            get => fields.BankAccount[this];
            set => fields.BankAccount[this] = value;
        }

        [DisplayName("Bank Name"), Size(200), NotNull]
        public String BankName
        {
            get => fields.BankName[this];
            set => fields.BankName[this] = value;
        }

        [DisplayName("Basic Salary"), NotNull]
        public Double? BasicSalary
        {
            get => fields.BasicSalary[this];
            set => fields.BasicSalary[this] = value;
        }

        [DisplayName("Total Income"), NotNull]
        public Double? TotalIncome
        {
            get => fields.TotalIncome[this];
            set => fields.TotalIncome[this] = value;
        }

        [DisplayName("Total Deduction"), NotNull]
        public Double? TotalDeduction
        {
            get => fields.TotalDeduction[this];
            set => fields.TotalDeduction[this] = value;
        }

        [DisplayName("Take Home Pay"), NotNull]
        public Double? TakeHomePay
        {
            get => fields.TakeHomePay[this];
            set => fields.TakeHomePay[this] = value;
        }

        [DisplayName("Employee"), Expression("(jEmployee.[FirstName] + ' ' + ISNULL(jEmployee.[MiddleName],'')+ ' '+ jEmployee.[LastName])"), MinSelectLevel(SelectLevel.List)]
        public string EmployeeFullName
        {
            get { return Fields.EmployeeFullName[this]; }
            set { Fields.EmployeeFullName[this] = value; }
        }
        [DisplayName("Incomes"), MasterDetailRelation(foreignKey: "PayrollDetailId"), MinSelectLevel(SelectLevel.List), NotMapped]
        public List<PayrollDetailIncomeRow> IncomeList
        {
            get => fields.IncomeList[this];
            set => fields.IncomeList[this] = value;
        }

        [DisplayName("Deductions"), MasterDetailRelation(foreignKey: "PayrollDetailId"), MinSelectLevel(SelectLevel.List), NotMapped]
        public List<PayrollDetailDeductionRow> DeductionList
        {
            get => fields.DeductionList[this];
            set => fields.DeductionList[this] = value;
        }
        public PayrollDetailRow()
            : base()
        {
        }

        public PayrollDetailRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field PayrollId;
            public Int64Field EmployeeId;
            public StringField BankAccount;
            public StringField BankName;
            public DoubleField BasicSalary;
            public DoubleField TotalIncome;
            public DoubleField TotalDeduction;
            public DoubleField TakeHomePay;
            public StringField EmployeeFullName;


            public RowListField<PayrollDetailIncomeRow> IncomeList;

            public RowListField<PayrollDetailDeductionRow> DeductionList;
        }
    }
}
