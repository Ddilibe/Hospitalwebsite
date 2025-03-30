using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using SmartERP.HumanResource.Entities;
using SmartERP.Masters;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.HumanResource
{
    [ConnectionKey("Default"), Module("HumanResource"), TableName("[dbo].[EmployeeDeduction]")]
    [DisplayName("Employee Deductions"), InstanceName("Employee Deductions")]
    [ReadPermission(PermissionKeys.Employees.View)]
    [InsertPermission(PermissionKeys.Employees.Create)]
    [UpdatePermission(PermissionKeys.Employees.Update)]
    [DeletePermission(PermissionKeys.Employees.Delete)]
    public sealed class EmployeeDeductionsRow : SmartERP.LoggingRow<EmployeeDeductionsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, PrimaryKey, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Employee"), NotNull, ForeignKey("[dbo].[Employees]", "Id"), LeftJoin("jEmployee"), TextualField("EmployeeFullName")]
        //[LookupEditor(typeof(EmployeesRow))]
        public Int64? EmployeeId
        {
            get => fields.EmployeeId[this];
            set => fields.EmployeeId[this] = value;
        }

        [DisplayName("Deduction"), NotNull, ForeignKey("[dbo].[Deduction]", "Id"), LeftJoin("jDeduction"), TextualField("DeductionName")]
        [LookupEditor(typeof(DeductionsRow), InplaceAdd = true)]
        public Int64? DeductionId
        {
            get => fields.DeductionId[this];
            set => fields.DeductionId[this] = value;
        }

        [DisplayName("Description"), Size(1000), QuickSearch]
        public String Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Amount"), NotNull]
        public Double? Amount
        {
            get => fields.Amount[this];
            set => fields.Amount[this] = value;
        }
        [DisplayName("Employee"), Expression("(jEmployee.[FirstName] + ' ' + ISNULL(jEmployee.[MiddleName],'')+ ' '+ jEmployee.[LastName])")]
        public string EmployeeFullName
        {
            get { return Fields.EmployeeFullName[this]; }
            set { Fields.EmployeeFullName[this] = value; }
        }
        [DisplayName("Deduction Name"), Expression("jDeduction.[Name]"), MinSelectLevel(SelectLevel.List), QuickSearch, NameProperty]
        public String DeductionName
        {
            get => fields.DeductionName[this];
            set => fields.DeductionName[this] = value;
        }
        public EmployeeDeductionsRow()
            : base()
        {
        }

        public EmployeeDeductionsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : SmartERP.LoggingRowFields
        {
            public Int64Field Id;
            public Int64Field EmployeeId;
            public Int64Field DeductionId;
            public StringField Description;
            public DoubleField Amount;

            public StringField EmployeeFullName;
            public StringField DeductionName;
        }

    }
}
