using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.RoomSettings
{
    [ConnectionKey("Default"), Module("RoomSettings"), TableName("[dbo].[BookingSoruces]")]
    [DisplayName("Booking Soruces"), InstanceName("Booking Soruce")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("RoomSettings.BookingSoruces")]
    public sealed class BookingSorucesRow : Row<BookingSorucesRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Booking Type"), NotNull, ForeignKey("[dbo].[BookingTypes]", "Id"), LeftJoin("jBookingType"), TextualField("BookingType")]
        [LookupEditor(typeof(BookingTypesRow))]
        public Int64? BookingTypeId
        {
            get => fields.BookingTypeId[this];
            set => fields.BookingTypeId[this] = value;
        }

        [DisplayName("Booking Soruce"), Size(250), NotNull, QuickSearch, NameProperty]
        public String BookingSoruce
        {
            get => fields.BookingSoruce[this];
            set => fields.BookingSoruce[this] = value;
        }

        [DisplayName("Commission Rate"), NotNull]
        public Double? CommissionRate
        {
            get => fields.CommissionRate[this];
            set => fields.CommissionRate[this] = value;
        }

        [DisplayName("Booking Type"), Expression("jBookingType.[BookingType]")]
        public String BookingType
        {
            get => fields.BookingType[this];
            set => fields.BookingType[this] = value;
        }

        public BookingSorucesRow()
            : base()
        {
        }

        public BookingSorucesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field BookingTypeId;
            public StringField BookingSoruce;
            public DoubleField CommissionRate;

            public StringField BookingType;
        }
    }
}
