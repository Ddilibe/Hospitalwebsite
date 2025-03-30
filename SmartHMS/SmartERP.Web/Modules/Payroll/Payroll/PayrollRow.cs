using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using SmartERP.Banks.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace SmartERP.Payroll
{
    [ConnectionKey("Default"), Module("Payroll"), TableName("[dbo].[Payroll]")]
    [DisplayName("Payroll"), InstanceName("Payroll")]
    [ReadPermission(SmartERP.HumanResource.PermissionKeys.Payroll.View)]
    [InsertPermission(SmartERP.HumanResource.PermissionKeys.Payroll.Create)]
    [UpdatePermission(SmartERP.HumanResource.PermissionKeys.Payroll.Update)]
    [DeletePermission(SmartERP.HumanResource.PermissionKeys.Payroll.Delete)]
    public sealed class PayrollRow : Row<PayrollRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }


        [DisplayName("Number"), Size(200), NotNull, QuickSearch, NameProperty]
        [Insertable(false), Updatable(false)]
        [DefaultValue("Auto Generated")]
        public String Number
        {
            get => fields.Number[this];
            set => fields.Number[this] = value;
        }

        [DisplayName("Description"), Size(1000)]
        public String Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Payment Date"), NotNull]
        public DateTime? PaymentDate
        {
            get => Serenity.Data.Field.PaymentDate[this];
            set => fields.PaymentDate[this] = value;
        }

        [DisplayName("Cash Bank"), NotNull, ForeignKey("[dbo].[Banks]", "Id"), LeftJoin("jBankName"), TextualField("CashBankName")]
        [LookupEditor(typeof(BanksRow))]
        public Int32? CashBankId
        {
            get => fields.CashBankId[this];
            set => fields.CashBankId[this] = value;
        }
        [DisplayName("Cash Bank"), Expression("jBankName.[BankName]"), MinSelectLevel(SelectLevel.List)]
        public String CashBankName
        {
            get { return Fields.CashBankName[this]; }
            set { Fields.CashBankName[this] = value; }
        }
        [DisplayName("Total Basic Salary")]
        //[DefaultValue(0), Insertable(false), Updatable(false)]
        [DefaultValue(0)]
        public Double? TotalBasicSalary
        {
            get => fields.TotalBasicSalary[this];
            set => fields.TotalBasicSalary[this] = value;
        }

        [DisplayName("Total Income")]
        //[DefaultValue(0), Insertable(false), Updatable(false)]
        [DefaultValue(0)]
        public Double? TotalIncome
        {
            get => fields.TotalIncome[this];
            set => fields.TotalIncome[this] = value;
        }

        [DisplayName("Total Deduction")]
        //[DefaultValue(0), Insertable(false), Updatable(false)]
        [DefaultValue(0)]
        public Double? TotalDeduction
        {
            get => fields.TotalDeduction[this];
            set => fields.TotalDeduction[this] = value;
        }

        [DisplayName("Total Take Home Pay")]
        //[DefaultValue(0), Insertable(false), Updatable(false)]
        [DefaultValue(0)]
        public Double? TotalTakeHomePay
        {
            get => fields.TotalTakeHomePay[this];
            set => fields.TotalTakeHomePay[this] = value;
        }

        [DisplayName("Total Payment Amount"), NotNull]
        [DefaultValue(0)]
        public Double? TotalPaymentAmount
        {
            get => fields.TotalPaymentAmount[this];
            set => fields.TotalPaymentAmount[this] = value;
        }
       
        [DisplayName("Currency"), Size(10), Updatable(false),ReadOnly(true)]
        public String CurrencyName
        {
            get => fields.CurrencyName[this];
            set => fields.CurrencyName[this] = value;
        }

        [DisplayName("Employee List"), MasterDetailRelation(foreignKey: "PayrollId"), NotMapped]
        public List<PayrollDetailRow> ItemList
        {
            get => fields.ItemList[this];
            set => fields.ItemList[this] = value;
        }
        public PayrollRow()
            : base()
        {
        }

        public PayrollRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public StringField Number;
            public StringField Description;
            public DateTimeField PaymentDate;
            public Int32Field CashBankId;
            public DoubleField TotalBasicSalary;
            public DoubleField TotalIncome;
            public DoubleField TotalDeduction;
            public DoubleField TotalTakeHomePay;
            public DoubleField TotalPaymentAmount;

            public RowListField<PayrollDetailRow> ItemList;
            public StringField CashBankName;

            public StringField CurrencyName;
        }
    }
}
