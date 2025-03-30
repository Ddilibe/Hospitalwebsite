using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.RoomSettings
{
    [ConnectionKey("Default"), Module("RoomSettings"), TableName("[dbo].[RoomTypes]")]
    [DisplayName("Room Types"), InstanceName("Room Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("RoomSettings.RoomTypes")]
    public sealed class RoomTypesRow : Row<RoomTypesRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Room Type"), Size(250), NotNull, QuickSearch, NameProperty]
        public String RoomType
        {
            get => fields.RoomType[this];
            set => fields.RoomType[this] = value;
        }

        public RoomTypesRow()
            : base()
        {
        }

        public RoomTypesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public StringField RoomType;
        }
    }
}
