using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.RoomFacilities
{
    [ConnectionKey("Default"), Module("RoomFacilities"), TableName("[dbo].[RoomFacilities]")]
    [DisplayName("Room Facilities"), InstanceName("Room Facility")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("RoomFacilities.RoomFacilities")]
    public sealed class RoomFacilitiesRow : Row<RoomFacilitiesRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Facility Type"), NotNull, ForeignKey("[dbo].[RoomFacilityTypes]", "Id"), LeftJoin("jFacilityType"), TextualField("FacilityTypeName")]
        [LookupEditor(typeof(RoomFacilityTypesRow))]
        public Int64? FacilityType
        {
            get => fields.FacilityType[this];
            set => fields.FacilityType[this] = value;
        }

        [DisplayName("Facility Name"), Size(250), NotNull, QuickSearch, NameProperty]
        public String FacilityName
        {
            get => fields.FacilityName[this];
            set => fields.FacilityName[this] = value;
        }

        [DisplayName("Image"), Size(250)]
        [ImageUploadEditor(AllowNonImage =false, FilenameFormat = "Images/~", CopyToHistory = true)]
        public String Image
        {
            get => fields.Image[this];
            set => fields.Image[this] = value;
        }

        [DisplayName("Facility Type Name"), Expression("jFacilityType.[Name]")]
        public String FacilityTypeName
        {
            get => fields.FacilityTypeName[this];
            set => fields.FacilityTypeName[this] = value;
        }

        public RoomFacilitiesRow()
            : base()
        {
        }

        public RoomFacilitiesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field FacilityType;
            public StringField FacilityName;
            public StringField Image;

            public StringField FacilityTypeName;
        }
    }
}
