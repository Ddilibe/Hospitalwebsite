using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.RoomSettings
{
    [ConnectionKey("Default"), Module("RoomSettings"), TableName("[dbo].[FloorPlans]")]
    [DisplayName("Floor Plans"), InstanceName("Floor Plan")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("RoomSettings.FloorPlans")]
    public sealed class FloorPlansRow : Row<FloorPlansRow.RowFields>, IIdRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Floor"), NotNull, ForeignKey("[dbo].[Floors]", "Id"), LeftJoin("jFloor"), TextualField("FloorName")]
        [LookupEditor(typeof(FloorsRow))]
        public Int64? Floor
        {
            get => fields.Floor[this];
            set => fields.Floor[this] = value;
        }

        [DisplayName("Start Room No"), NotNull]
        public Int32? StartRoomNo
        {
            get => fields.StartRoomNo[this];
            set => fields.StartRoomNo[this] = value;
        }

        [DisplayName("No Of Room")]
        public Int32? NoOfRoom
        {
            get => fields.NoOfRoom[this];
            set => fields.NoOfRoom[this] = value;
        }

        [DisplayName("Floor Name"), Expression("jFloor.[Name]")]
        public String FloorName
        {
            get => fields.FloorName[this];
            set => fields.FloorName[this] = value;
        }

        public FloorPlansRow()
            : base()
        {
        }

        public FloorPlansRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field Floor;
            public Int32Field StartRoomNo;
            public Int32Field NoOfRoom;

            public StringField FloorName;
        }
    }
}
