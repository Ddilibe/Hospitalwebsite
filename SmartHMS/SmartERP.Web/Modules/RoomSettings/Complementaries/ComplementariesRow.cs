using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.RoomSettings
{
    [ConnectionKey("Default"), Module("RoomSettings"), TableName("[dbo].[Complementaries]")]
    [DisplayName("Complementaries"), InstanceName("Complementary")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("RoomSettings.Complementaries")]
    public sealed class ComplementariesRow : Row<ComplementariesRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Room Type"), NotNull, ForeignKey("[dbo].[RoomTypes]", "Id"), LeftJoin("jRoomType"), TextualField("RoomType1")]
        [LookupEditor(typeof(RoomTypesRow))]
        public Int64? RoomType
        {
            get => fields.RoomType[this];
            set => fields.RoomType[this] = value;
        }

        [DisplayName("Complementary"), Size(250), NotNull, QuickSearch, NameProperty]
        public String Complementary
        {
            get => fields.Complementary[this];
            set => fields.Complementary[this] = value;
        }

        [DisplayName("Rate"), NotNull]
        public Double? Rate
        {
            get => fields.Rate[this];
            set => fields.Rate[this] = value;
        }

        [DisplayName("Room Type"), Expression("jRoomType.[RoomType]")]
        public String RoomType1
        {
            get => fields.RoomType1[this];
            set => fields.RoomType1[this] = value;
        }

        public ComplementariesRow()
            : base()
        {
        }

        public ComplementariesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field RoomType;
            public StringField Complementary;
            public DoubleField Rate;

            public StringField RoomType1;
        }
    }
}
