
namespace SmartERP.HumanResource.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using SmartERP.Banks.Entities;
    using SmartERP.Masters.Entities;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("HumanResource"), TableName("[dbo].[EmployeeBankAccounts]")]
    [DisplayName("Employee Bank Accounts"), InstanceName("Employee Bank Accounts")]
    [ReadPermission(PermissionKeys.EmployeeBankAccounts.View)]
    [InsertPermission(PermissionKeys.EmployeeBankAccounts.Create)]
    [UpdatePermission(PermissionKeys.EmployeeBankAccounts.Update)]
    [DeletePermission(PermissionKeys.EmployeeBankAccounts.Delete)]

    [LookupScript("HumanResource.EmployeeBankAccounts", Expiration = -1)]
    public sealed class EmployeeBankAccountsRow : Row<EmployeeBankAccountsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty, Unique]
        public Int64? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Employee"), NotNull, ForeignKey("[dbo].[Employees]", "Id"), LeftJoin("jEmployee"), TextualField("EmployeeFirstName")]
        [LookupEditor(typeof(EmployeesRow))]
        public Int64? Employee
        {
            get { return Fields.Employee[this]; }
            set { Fields.Employee[this] = value; }
        }

        [DisplayName("Account Title"), Size(250), NotNull, QuickSearch,NameProperty]
        public String AccountTitle
        {
            get { return Fields.AccountTitle[this]; }
            set { Fields.AccountTitle[this] = value; }
        }

        [DisplayName("Account Number"), Size(250), NotNull]
        public String AccountNumber
        {
            get { return Fields.AccountNumber[this]; }
            set { Fields.AccountNumber[this] = value; }
        }

        [DisplayName("Bank Name"), NotNull, ForeignKey("[dbo].[Banks]", "Id"), LeftJoin("jBankName"), TextualField("BankName1")]
        [LookupEditor(typeof(BanksRow))]
        public Int64? BankName
        {
            get { return Fields.BankName[this]; }
            set { Fields.BankName[this] = value; }
        }

        [DisplayName("Bank Code"), Size(250), NotNull]
        public String BankCode
        {
            get { return Fields.BankCode[this]; }
            set { Fields.BankCode[this] = value; }
        }

        [DisplayName("Bank Branch"), Size(250)]
        public String BankBranch
        {
            get { return Fields.BankBranch[this]; }
            set { Fields.BankBranch[this] = value; }
        }

        [DisplayName("Employee First Name"), Expression("jEmployee.[FirstName]")]
        public String EmployeeFirstName
        {
            get { return Fields.EmployeeFirstName[this]; }
            set { Fields.EmployeeFirstName[this] = value; }
        }

        [DisplayName("Employee Last Name"), Expression("jEmployee.[LastName]")]
        public String EmployeeLastName
        {
            get { return Fields.EmployeeLastName[this]; }
            set { Fields.EmployeeLastName[this] = value; }
        }

        [DisplayName("Employee Employee Code"), Expression("jEmployee.[EmployeeCode]")]
        public Int64? EmployeeEmployeeCode
        {
            get { return Fields.EmployeeEmployeeCode[this]; }
            set { Fields.EmployeeEmployeeCode[this] = value; }
        }

        [DisplayName("Employee Date Of Joining"), Expression("jEmployee.[DateOfJoining]")]
        public DateTime? EmployeeDateOfJoining
        {
            get { return Fields.EmployeeDateOfJoining[this]; }
            set { Fields.EmployeeDateOfJoining[this] = value; }
        }

        [DisplayName("Employee Company"), Expression("jEmployee.[Company]")]
        public Int64? EmployeeCompany
        {
            get { return Fields.EmployeeCompany[this]; }
            set { Fields.EmployeeCompany[this] = value; }
        }

        [DisplayName("Employee Location"), Expression("jEmployee.[Location]")]
        public Int64? EmployeeLocation
        {
            get { return Fields.EmployeeLocation[this]; }
            set { Fields.EmployeeLocation[this] = value; }
        }

        [DisplayName("Employee Department"), Expression("jEmployee.[Department]")]
        public Int64? EmployeeDepartment
        {
            get { return Fields.EmployeeDepartment[this]; }
            set { Fields.EmployeeDepartment[this] = value; }
        }

        [DisplayName("Employee Designation"), Expression("jEmployee.[Designation]")]
        public Int64? EmployeeDesignation
        {
            get { return Fields.EmployeeDesignation[this]; }
            set { Fields.EmployeeDesignation[this] = value; }
        }

        [DisplayName("Employee Username"), Expression("jEmployee.[Username]")]
        public Int32? EmployeeUsername
        {
            get { return Fields.EmployeeUsername[this]; }
            set { Fields.EmployeeUsername[this] = value; }
        }

        [DisplayName("Employee Email"), Expression("jEmployee.[Email]")]
        public String EmployeeEmail
        {
            get { return Fields.EmployeeEmail[this]; }
            set { Fields.EmployeeEmail[this] = value; }
        }

        [DisplayName("Employee Gender"), Expression("jEmployee.[Gender]")]
        public Int32? EmployeeGender
        {
            get { return Fields.EmployeeGender[this]; }
            set { Fields.EmployeeGender[this] = value; }
        }

        [DisplayName("Employee Office Shift"), Expression("jEmployee.[OfficeShift]")]
        public Int64? EmployeeOfficeShift
        {
            get { return Fields.EmployeeOfficeShift[this]; }
            set { Fields.EmployeeOfficeShift[this] = value; }
        }

        [DisplayName("Employee Date Of Birth"), Expression("jEmployee.[DateOfBirth]")]
        public DateTime? EmployeeDateOfBirth
        {
            get { return Fields.EmployeeDateOfBirth[this]; }
            set { Fields.EmployeeDateOfBirth[this] = value; }
        }

        [DisplayName("Employee Contact Number"), Expression("jEmployee.[ContactNumber]")]
        public String EmployeeContactNumber
        {
            get { return Fields.EmployeeContactNumber[this]; }
            set { Fields.EmployeeContactNumber[this] = value; }
        }

        [DisplayName("Employee Reports To"), Expression("jEmployee.[ReportsTo]")]
        public Int64? EmployeeReportsTo
        {
            get { return Fields.EmployeeReportsTo[this]; }
            set { Fields.EmployeeReportsTo[this] = value; }
        }

        [DisplayName("Employee Pin Code"), Expression("jEmployee.[PinCode]")]
        public Int32? EmployeePinCode
        {
            get { return Fields.EmployeePinCode[this]; }
            set { Fields.EmployeePinCode[this] = value; }
        }

        [DisplayName("Employee Address"), Expression("jEmployee.[Address]")]
        public String EmployeeAddress
        {
            get { return Fields.EmployeeAddress[this]; }
            set { Fields.EmployeeAddress[this] = value; }
        }

        [DisplayName("Employee Photo"), Expression("jEmployee.[Photo]")]
        public String EmployeePhoto
        {
            get { return Fields.EmployeePhoto[this]; }
            set { Fields.EmployeePhoto[this] = value; }
        }

        [DisplayName("Bank Name"), Expression("jBankName.[BankName]"),MinSelectLevel(SelectLevel.List)]
        public String BankName1
        {
            get { return Fields.BankName1[this]; }
            set { Fields.BankName1[this] = value; }
        }

       
        public EmployeeBankAccountsRow()
        {
        }

        public EmployeeBankAccountsRow(RowFields fields)
            : base(fields)
        {
        }
        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field Employee;
            public StringField AccountTitle;
            public StringField AccountNumber;
            public Int64Field BankName;
            public StringField BankCode;
            public StringField BankBranch;

            public StringField EmployeeFirstName;
            public StringField EmployeeLastName;
            public Int64Field EmployeeEmployeeCode;
            public DateTimeField EmployeeDateOfJoining;
            public Int64Field EmployeeCompany;
            public Int64Field EmployeeLocation;
            public Int64Field EmployeeDepartment;
            public Int64Field EmployeeDesignation;
            public Int32Field EmployeeUsername;
            public StringField EmployeeEmail;
            public Int32Field EmployeeGender;
            public Int64Field EmployeeOfficeShift;
            public DateTimeField EmployeeDateOfBirth;
            public StringField EmployeeContactNumber;
            public Int64Field EmployeeReportsTo;
            public Int32Field EmployeePinCode;
            public StringField EmployeeAddress;
            public StringField EmployeePhoto;

            public StringField BankName1;
        }
    }
}
