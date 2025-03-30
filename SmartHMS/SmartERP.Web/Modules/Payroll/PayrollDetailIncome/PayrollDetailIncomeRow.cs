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
    [ConnectionKey("Default"), Module("Payroll"), TableName("[dbo].[PayrollDetailIncome]")]
    [DisplayName("Payroll Detail Income"), InstanceName("Payroll Detail Income")]
    [ReadPermission(SmartERP.HumanResource.PermissionKeys.Payroll.View)]
    [InsertPermission(SmartERP.HumanResource.PermissionKeys.Payroll.Create)]
    [UpdatePermission(SmartERP.HumanResource.PermissionKeys.Payroll.Update)]
    [DeletePermission(SmartERP.HumanResource.PermissionKeys.Payroll.Delete)]
    public sealed class PayrollDetailIncomeRow : Row<PayrollDetailIncomeRow.RowFields>, IIdRow, INameRow
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

        [DisplayName("Income"), NotNull, ForeignKey("[dbo].[Income]", "Id"), LeftJoin("jIncome"), TextualField("IncomeName")]
        [LookupEditor(typeof(IncomesRow))]
        public Int64? IncomeId
        {
            get => fields.IncomeId[this];
            set => fields.IncomeId[this] = value;
        }
        [DisplayName("Income Name"), Expression("jIncome.[Name]"), MinSelectLevel(SelectLevel.List), QuickSearch, NameProperty]
        public String IncomeName
        {
            get => fields.IncomeName[this];
            set => fields.IncomeName[this] = value;
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

        public PayrollDetailIncomeRow()
            : base()
        {
        }

        public PayrollDetailIncomeRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field PayrollDetailId;
            public Int64Field IncomeId;
            public StringField ShortNote;
            public DoubleField Amount;

            public StringField IncomeName;
        }
    }
}
