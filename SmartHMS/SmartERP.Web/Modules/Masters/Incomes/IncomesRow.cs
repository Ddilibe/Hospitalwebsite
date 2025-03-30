using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[Income]")]
    [DisplayName("Incomes"), InstanceName("Incomes")]
   
    [ReadPermission(PermissionKeys.Incomes.View)]
    [InsertPermission(PermissionKeys.Incomes.Create)]
    [UpdatePermission(PermissionKeys.Incomes.Update)]
    [DeletePermission(PermissionKeys.Incomes.Delete)]
    [LookupScript("Masters.Incomes", Expiration = -1)]
    public sealed class IncomesRow : SmartERP.LoggingRow<IncomesRow.RowFields>, IIdRow, INameRow
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

        public IncomesRow()
            : base()
        {
        }

        public IncomesRow(RowFields fields)
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
