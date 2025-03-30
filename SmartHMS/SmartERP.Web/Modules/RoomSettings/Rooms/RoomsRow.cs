using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using SmartERP.RoomFacilities;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.RoomSettings
{
    [ConnectionKey("Default"), Module("RoomSettings"), TableName("[dbo].[Rooms]")]
    [DisplayName("Rooms"), InstanceName("Room")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("RoomSettings.Rooms")]
    public sealed class RoomsRow : Row<RoomsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Room Type"), NotNull, ForeignKey("[dbo].[RoomTypes]", "Id"), LeftJoin("jRoomType"), TextualField("RoomType")]
        [LookupEditor(typeof(RoomTypesRow))]
        public Int64? RoomTypeId
        {
            get => fields.RoomTypeId[this];
            set => fields.RoomTypeId[this] = value;
        }

        [DisplayName("Room No"), NotNull]
        public Int32? RoomNo
        {
            get => fields.RoomNo[this];
            set => fields.RoomNo[this] = value;
        }

        [DisplayName("Capacity"), NotNull]
        public Int32? Capacity
        {
            get => fields.Capacity[this];
            set => fields.Capacity[this] = value;
        }

        [DisplayName("Extra Capability"), NotNull]
        public Int32? ExtraCapability
        {
            get => fields.ExtraCapability[this];
            set => fields.ExtraCapability[this] = value;
        }

        [DisplayName("Rate"), NotNull]
        public Double? Rate
        {
            get => fields.Rate[this];
            set => fields.Rate[this] = value;
        }

        [DisplayName("Bed Charge"), NotNull]
        public Double? BedCharge
        {
            get => fields.BedCharge[this];
            set => fields.BedCharge[this] = value;
        }

        [DisplayName("Person Charge"), NotNull]
        public Double? PersonCharge
        {
            get => fields.PersonCharge[this];
            set => fields.PersonCharge[this] = value;
        }

        [DisplayName("Room Size"), NotNull]
        public Int32? RoomSize
        {
            get => fields.RoomSize[this];
            set => fields.RoomSize[this] = value;
        }

        [DisplayName("Room Size Type"), NotNull, ForeignKey("[dbo].[RoomSizes]", "Id"), LeftJoin("jRoomSizeType"), TextualField("RoomSizeTypeName")]
        [LookupEditor(typeof(RoomSizesRow))]
        public Int64? RoomSizeType
        {
            get => fields.RoomSizeType[this];
            set => fields.RoomSizeType[this] = value;
        }

        [DisplayName("Bed No"), NotNull]
        public Int32? BedNo
        {
            get => fields.BedNo[this];
            set => fields.BedNo[this] = value;
        }

        [DisplayName("Bed Type"), NotNull, ForeignKey("[dbo].[BedTypes]", "Id"), LeftJoin("jBedType"), TextualField("BedTypeName")]
        [LookupEditor(typeof(BedTypesRow))]
        public Int64? BedType
        {
            get => fields.BedType[this];
            set => fields.BedType[this] = value;
        }

        [DisplayName("Room Drescription"), Size(1073741823), QuickSearch, NameProperty]
        public String RoomDrescription
        {
            get => fields.RoomDrescription[this];
            set => fields.RoomDrescription[this] = value;
        }

        [DisplayName("Reserve Condition"), Size(4000)]
        public String ReserveCondition
        {
            get => fields.ReserveCondition[this];
            set => fields.ReserveCondition[this] = value;
        }

        [DisplayName("Room Type"), Expression("jRoomType.[RoomType]")]
        public String RoomType
        {
            get => fields.RoomType[this];
            set => fields.RoomType[this] = value;
        }

        [DisplayName("Room Size Type Name"), Expression("jRoomSizeType.[Name]")]
        public String RoomSizeTypeName
        {
            get => fields.RoomSizeTypeName[this];
            set => fields.RoomSizeTypeName[this] = value;
        }

        [DisplayName("Bed Type Name"), Expression("jBedType.[Name]")]
        public String BedTypeName
        {
            get => fields.BedTypeName[this];
            set => fields.BedTypeName[this] = value;
        }

        public RoomsRow()
            : base()
        {
        }

        public RoomsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field RoomTypeId;
            public Int32Field RoomNo;
            public Int32Field Capacity;
            public Int32Field ExtraCapability;
            public DoubleField Rate;
            public DoubleField BedCharge;
            public DoubleField PersonCharge;
            public Int32Field RoomSize;
            public Int64Field RoomSizeType;
            public Int32Field BedNo;
            public Int64Field BedType;
            public StringField RoomDrescription;
            public StringField ReserveCondition;

            public StringField RoomType;

            public StringField RoomSizeTypeName;

            public StringField BedTypeName;
        }
    }
}
