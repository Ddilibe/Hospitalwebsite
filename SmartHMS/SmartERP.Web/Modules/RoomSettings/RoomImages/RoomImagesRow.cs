using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.RoomSettings
{
    [ConnectionKey("Default"), Module("RoomSettings"), TableName("[dbo].[RoomImages]")]
    [DisplayName("Room Images"), InstanceName("Room Image")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("RoomSettings.RoomImages")]
    public sealed class RoomImagesRow : Row<RoomImagesRow.RowFields>, IIdRow, INameRow
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

        [DisplayName("Image"), Size(250), NotNull, QuickSearch, NameProperty]
        public String Image
        {
            get => fields.Image[this];
            set => fields.Image[this] = value;
        }

        [DisplayName("Room Type"), Expression("jRoomType.[RoomType]")]
        public String RoomType1
        {
            get => fields.RoomType1[this];
            set => fields.RoomType1[this] = value;
        }

        public RoomImagesRow()
            : base()
        {
        }

        public RoomImagesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field RoomType;
            public StringField Image;

            public StringField RoomType1;
        }
    }
}
