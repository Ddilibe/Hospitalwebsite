using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[Deduction]")]
    [DisplayName("Deductions"), InstanceName("Deductions")]
   
    [ReadPermission(PermissionKeys.Deductions.View)]
    [InsertPermission(PermissionKeys.Deductions.Create)]
    [UpdatePermission(PermissionKeys.Deductions.Update)]
    [DeletePermission(PermissionKeys.Deductions.Delete)]
    [LookupScript("Masters.Deductions", Expiration = -1)]
    public sealed class DeductionsRow : SmartERP.LoggingRow<DeductionsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, PrimaryKey, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), Size(200), NotNull, QuickSearch, NameProperty]
        public String Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Description"), Size(1000)]
        public String Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        public DeductionsRow()
            : base()
        {
        }

        public DeductionsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field Id;
            public StringField Name;
            public StringField Description;
        }
    }
}
