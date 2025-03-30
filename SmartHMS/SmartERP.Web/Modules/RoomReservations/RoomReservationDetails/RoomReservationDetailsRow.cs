using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using SmartERP.RoomSettings;
using System;
using System.ComponentModel;
using System.IO;

namespace SmartERP.RoomReservations
{
    [ConnectionKey("Default"), Module("RoomReservations"), TableName("[dbo].[RoomReservationDetails]")]
    [DisplayName("Room Reservation Details"), InstanceName("Room Detail")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class RoomReservationDetailsRow : Row<RoomReservationDetailsRow.RowFields>, IIdRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Room Reservation"), NotNull, ForeignKey("[dbo].[RoomReservations]", "Id"), LeftJoin("jRoomReservation"), TextualField("RoomReservationArivalFrom")]
        public Int64? RoomReservationId
        {
            get => fields.RoomReservationId[this];
            set => fields.RoomReservationId[this] = value;
        }

        [DisplayName("Room Type"), NotNull, ForeignKey("[dbo].[RoomTypes]", "Id"), LeftJoin("jRoomType"), TextualField("RoomType")]
        [LookupEditor(typeof(RoomTypesRow))]
        public Int64? RoomTypeId
        {
            get => fields.RoomTypeId[this];
            set => fields.RoomTypeId[this] = value;
        }

        [DisplayName("Room No"), NotNull, ForeignKey("[dbo].[Rooms]", "Id"), LeftJoin("jRoomNo"), TextualField("RoomNoRoomDrescription")]
        [LookupEditor(typeof(RoomsRow))]
        public Int64? RoomNoId
        {
            get => fields.RoomNoId[this];
            set => fields.RoomNoId[this] = value;
        }

        [DisplayName("Adults"), NotNull]
        public Int32? Adults
        {
            get => fields.Adults[this];
            set => fields.Adults[this] = value;
        }

        [DisplayName("Children"), NotNull]
        public Int32? Children
        {
            get => fields.Children[this];
            set => fields.Children[this] = value;
        }

        [DisplayName("Check In"), NotNull]
        public DateTime? CheckIn
        {
            get => fields.CheckIn[this];
            set => fields.CheckIn[this] = value;
        }

        [DisplayName("Check Out")]
        public DateTime? CheckOut
        {
            get => fields.CheckOut[this];
            set => fields.CheckOut[this] = value;
        }

        [DisplayName("Rent"), NotNull]
        public Double? Rent
        {
            get => fields.Rent[this];
            set => fields.Rent[this] = value;
        }

        [DisplayName("Room Reservation Customer Id"), Expression("jRoomReservation.[CustomerId]")]
        public Int64? RoomReservationCustomerId
        {
            get => fields.RoomReservationCustomerId[this];
            set => fields.RoomReservationCustomerId[this] = value;
        }

        [DisplayName("Room Reservation Check In"), Expression("jRoomReservation.[CheckIn]")]
        public DateTime? RoomReservationCheckIn
        {
            get => fields.RoomReservationCheckIn[this];
            set => fields.RoomReservationCheckIn[this] = value;
        }

        [DisplayName("Room Reservation Check Out"), Expression("jRoomReservation.[CheckOut]")]
        public DateTime? RoomReservationCheckOut
        {
            get => fields.RoomReservationCheckOut[this];
            set => fields.RoomReservationCheckOut[this] = value;
        }

        [DisplayName("Room Reservation Arival From"), Expression("jRoomReservation.[ArivalFrom]")]
        public String RoomReservationArivalFrom
        {
            get => fields.RoomReservationArivalFrom[this];
            set => fields.RoomReservationArivalFrom[this] = value;
        }

        [DisplayName("Room Reservation Booking Type Id"), Expression("jRoomReservation.[BookingTypeId]")]
        public Int64? RoomReservationBookingTypeId
        {
            get => fields.RoomReservationBookingTypeId[this];
            set => fields.RoomReservationBookingTypeId[this] = value;
        }

        [DisplayName("Room Reservation Booking Reference Id"), Expression("jRoomReservation.[BookingReferenceId]")]
        public Int64? RoomReservationBookingReferenceId
        {
            get => fields.RoomReservationBookingReferenceId[this];
            set => fields.RoomReservationBookingReferenceId[this] = value;
        }

        [DisplayName("Room Reservation Choose Booking Reference"), Expression("jRoomReservation.[ChooseBookingReference]")]
        public String RoomReservationChooseBookingReference
        {
            get => fields.RoomReservationChooseBookingReference[this];
            set => fields.RoomReservationChooseBookingReference[this] = value;
        }

        [DisplayName("Room Reservation Purpose Of Visit"), Expression("jRoomReservation.[PurposeOfVisit]")]
        public String RoomReservationPurposeOfVisit
        {
            get => fields.RoomReservationPurposeOfVisit[this];
            set => fields.RoomReservationPurposeOfVisit[this] = value;
        }

        [DisplayName("Room Reservation Remarks"), Expression("jRoomReservation.[Remarks]")]
        public String RoomReservationRemarks
        {
            get => fields.RoomReservationRemarks[this];
            set => fields.RoomReservationRemarks[this] = value;
        }

        [DisplayName("Room Reservation Booking Charge"), Expression("jRoomReservation.[BookingCharge]")]
        public Double? RoomReservationBookingCharge
        {
            get => fields.RoomReservationBookingCharge[this];
            set => fields.RoomReservationBookingCharge[this] = value;
        }

        [DisplayName("Room Reservation Tax"), Expression("jRoomReservation.[Tax]")]
        public Double? RoomReservationTax
        {
            get => fields.RoomReservationTax[this];
            set => fields.RoomReservationTax[this] = value;
        }

        [DisplayName("Room Reservation Service Charge"), Expression("jRoomReservation.[ServiceCharge]")]
        public Double? RoomReservationServiceCharge
        {
            get => fields.RoomReservationServiceCharge[this];
            set => fields.RoomReservationServiceCharge[this] = value;
        }

        [DisplayName("Room Reservation Total"), Expression("jRoomReservation.[Total]")]
        public Double? RoomReservationTotal
        {
            get => fields.RoomReservationTotal[this];
            set => fields.RoomReservationTotal[this] = value;
        }

        [DisplayName("Room Type"), Expression("jRoomType.[RoomType]")]
        public String RoomType
        {
            get => fields.RoomType[this];
            set => fields.RoomType[this] = value;
        }

        [DisplayName("Room No Room Type Id"), Expression("jRoomNo.[RoomTypeId]")]
        public Int64? RoomNoRoomTypeId
        {
            get => fields.RoomNoRoomTypeId[this];
            set => fields.RoomNoRoomTypeId[this] = value;
        }

        [DisplayName("Room No"), Expression("jRoomNo.[RoomNo]")]
        public Int32? RoomNo
        {
            get => fields.RoomNo[this];
            set => fields.RoomNo[this] = value;
        }

        [DisplayName("Room No Capacity"), Expression("jRoomNo.[Capacity]")]
        public Int32? RoomNoCapacity
        {
            get => fields.RoomNoCapacity[this];
            set => fields.RoomNoCapacity[this] = value;
        }

        [DisplayName("Room No Extra Capability"), Expression("jRoomNo.[ExtraCapability]")]
        public Int32? RoomNoExtraCapability
        {
            get => fields.RoomNoExtraCapability[this];
            set => fields.RoomNoExtraCapability[this] = value;
        }

        [DisplayName("Room No Rate"), Expression("jRoomNo.[Rate]")]
        public Double? RoomNoRate
        {
            get => fields.RoomNoRate[this];
            set => fields.RoomNoRate[this] = value;
        }

        [DisplayName("Room No Bed Charge"), Expression("jRoomNo.[BedCharge]")]
        public Double? RoomNoBedCharge
        {
            get => fields.RoomNoBedCharge[this];
            set => fields.RoomNoBedCharge[this] = value;
        }

        [DisplayName("Room No Person Charge"), Expression("jRoomNo.[PersonCharge]")]
        public Double? RoomNoPersonCharge
        {
            get => fields.RoomNoPersonCharge[this];
            set => fields.RoomNoPersonCharge[this] = value;
        }

        [DisplayName("Room No Room Size"), Expression("jRoomNo.[RoomSize]")]
        public Int32? RoomNoRoomSize
        {
            get => fields.RoomNoRoomSize[this];
            set => fields.RoomNoRoomSize[this] = value;
        }

        [DisplayName("Room No Room Size Type"), Expression("jRoomNo.[RoomSizeType]")]
        public Int64? RoomNoRoomSizeType
        {
            get => fields.RoomNoRoomSizeType[this];
            set => fields.RoomNoRoomSizeType[this] = value;
        }

        [DisplayName("Room No Bed No"), Expression("jRoomNo.[BedNo]")]
        public Int32? RoomNoBedNo
        {
            get => fields.RoomNoBedNo[this];
            set => fields.RoomNoBedNo[this] = value;
        }

        [DisplayName("Room No Bed Type"), Expression("jRoomNo.[BedType]")]
        public Int64? RoomNoBedType
        {
            get => fields.RoomNoBedType[this];
            set => fields.RoomNoBedType[this] = value;
        }

        [DisplayName("Room No Room Drescription"), Expression("jRoomNo.[RoomDrescription]")]
        public String RoomNoRoomDrescription
        {
            get => fields.RoomNoRoomDrescription[this];
            set => fields.RoomNoRoomDrescription[this] = value;
        }

        [DisplayName("Room No Reserve Condition"), Expression("jRoomNo.[ReserveCondition]")]
        public String RoomNoReserveCondition
        {
            get => fields.RoomNoReserveCondition[this];
            set => fields.RoomNoReserveCondition[this] = value;
        }
        [DisplayName("Room No"), Expression("jRoomNo.[RoomNo]")]
        public int? RoomRoomNo
        {
            get => fields.RoomRoomNo[this];
            set => fields.RoomRoomNo[this] = value;
        }

        [DisplayName("Room Type "), Expression("jRoomType.[RoomType]")]
        public string RoomTypeBookingSoruce
        {
            get => fields.RoomTypeBookingSoruce[this];
            set => fields.RoomTypeBookingSoruce[this] = value;
        }
        public RoomReservationDetailsRow()
            : base()
        {
        }

        public RoomReservationDetailsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field RoomReservationId;
            public Int64Field RoomTypeId;
            public Int64Field RoomNoId;
            public Int32Field Adults;
            public Int32Field Children;
            public DateTimeField CheckIn;
            public DateTimeField CheckOut;
            public DoubleField Rent;

            public Int64Field RoomReservationCustomerId;
            public DateTimeField RoomReservationCheckIn;
            public DateTimeField RoomReservationCheckOut;
            public StringField RoomReservationArivalFrom;
            public Int64Field RoomReservationBookingTypeId;
            public Int64Field RoomReservationBookingReferenceId;
            public StringField RoomReservationChooseBookingReference;
            public StringField RoomReservationPurposeOfVisit;
            public StringField RoomReservationRemarks;
            public DoubleField RoomReservationBookingCharge;
            public DoubleField RoomReservationTax;
            public DoubleField RoomReservationServiceCharge;
            public DoubleField RoomReservationTotal;

            public StringField RoomType;
            public StringField RoomTypeBookingSoruce;

            public Int64Field RoomNoRoomTypeId;
            public Int32Field RoomNo;
            public Int32Field RoomNoCapacity;
            public Int32Field RoomNoExtraCapability;
            public DoubleField RoomNoRate;
            public DoubleField RoomNoBedCharge;
            public DoubleField RoomNoPersonCharge;
            public Int32Field RoomNoRoomSize;
            public Int64Field RoomNoRoomSizeType;
            public Int32Field RoomNoBedNo;
            public Int64Field RoomNoBedType;
            public StringField RoomNoRoomDrescription;
            public StringField RoomNoReserveCondition;
            public Int32Field RoomRoomNo;
        }
    }
}
