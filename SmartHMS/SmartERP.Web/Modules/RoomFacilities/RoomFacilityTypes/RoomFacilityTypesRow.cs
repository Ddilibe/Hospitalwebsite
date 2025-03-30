using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.RoomFacilities
{
    [ConnectionKey("Default"), Module("RoomFacilities"), TableName("[dbo].[RoomFacilityTypes]")]
    [DisplayName("Room Facility Types"), InstanceName("Room Facility Type")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("RoomFacilities.RoomFacilityTypes")]
    public sealed class RoomFacilityTypesRow : Row<RoomFacilityTypesRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), Size(250), QuickSearch, NameProperty]
        public String Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        public RoomFacilityTypesRow()
            : base()
        {
        }

        public RoomFacilityTypesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public StringField Name;
        }
    }
}
