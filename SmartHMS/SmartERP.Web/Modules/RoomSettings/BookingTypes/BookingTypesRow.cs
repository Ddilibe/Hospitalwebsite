using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.RoomSettings
{
    [ConnectionKey("Default"), Module("RoomSettings"), TableName("[dbo].[BookingTypes]")]
    [DisplayName("Booking Types"), InstanceName("Booking Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("RoomSettings.BookingTypes")]
    public sealed class BookingTypesRow : Row<BookingTypesRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Booking Type"), Size(250), NotNull, QuickSearch, NameProperty]
        public String BookingType
        {
            get => fields.BookingType[this];
            set => fields.BookingType[this] = value;
        }

        public BookingTypesRow()
            : base()
        {
        }

        public BookingTypesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public StringField BookingType;
        }
    }
}
