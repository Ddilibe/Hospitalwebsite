using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using SmartERP.Masters;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.Payroll
{
    [ConnectionKey("Default"), Module("Payroll"), TableName("[dbo].[PayrollDetailDeduction]")]
    [DisplayName("Payroll Detail Deduction"), InstanceName("Payroll Detail Deduction")]
    [ReadPermission(SmartERP.HumanResource.PermissionKeys.Payroll.View)]
    [InsertPermission(SmartERP.HumanResource.PermissionKeys.Payroll.Create)]
    [UpdatePermission(SmartERP.HumanResource.PermissionKeys.Payroll.Update)]
    [DeletePermission(SmartERP.HumanResource.PermissionKeys.Payroll.Delete)]
    public sealed class PayrollDetailDeductionRow : Row<PayrollDetailDeductionRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Payroll Detail Id"), NotNull]
        public Int64? PayrollDetailId
        {
            get => fields.PayrollDetailId[this];
            set => fields.PayrollDetailId[this] = value;
        }

        [DisplayName("Deduction"), NotNull, ForeignKey("[dbo].[Deduction]", "Id"), LeftJoin("jDeduction"), TextualField("DeductionName")]
        [LookupEditor(typeof(DeductionsRow))]
       
        public Int64? DeductionId
        {
            get => fields.DeductionId[this];
            set => fields.DeductionId[this] = value;
        }

        [DisplayName("Deduction Name"), Expression("jDeduction.[Name]"), MinSelectLevel(SelectLevel.List), QuickSearch, NameProperty]
        public String DeductionName
        {
            get => fields.DeductionName[this];
            set => fields.DeductionName[this] = value;
        }

        [DisplayName("Short Note"), Size(100), QuickSearch]
        public String ShortNote
        {
            get => fields.ShortNote[this];
            set => fields.ShortNote[this] = value;
        }

        [DisplayName("Amount"), NotNull]
        public Double? Amount
        {
            get => fields.Amount[this];
            set => fields.Amount[this] = value;
        }

        public PayrollDetailDeductionRow()
            : base()
        {
        }

        public PayrollDetailDeductionRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field PayrollDetailId;
            public Int64Field DeductionId;
            public StringField ShortNote;
            public DoubleField Amount;
            public StringField DeductionName;
        }
    }
}
