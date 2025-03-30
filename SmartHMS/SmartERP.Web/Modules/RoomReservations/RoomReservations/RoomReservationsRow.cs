using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using SmartERP.Customers.Entities;
using SmartERP.RoomSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace SmartERP.RoomReservations
{
    [ConnectionKey("Default"), Module("RoomReservations"), TableName("[dbo].[RoomReservations]")]
    [DisplayName("Room Reservations"), InstanceName("Room Reservation")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("RoomReservations.RoomReservations")]
    public sealed class RoomReservationsRow : Row<RoomReservationsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int64? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Customer"), NotNull, ForeignKey("[dbo].[Customers]", "Id"), LeftJoin("jCustomer"), TextualField("CustomerName")]
        [LookupEditor(typeof(CustomersRow), InplaceAdd = true, FilterField = "IsActive", FilterValue = "1", DialogType = "Customers.Customers"), LookupInclude]
        public Int64? CustomerId
        {
            get => fields.CustomerId[this];
            set => fields.CustomerId[this] = value;
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

        [DisplayName("Arival From"), Size(250), QuickSearch, NameProperty]
        public String ArivalFrom
        {
            get => fields.ArivalFrom[this];
            set => fields.ArivalFrom[this] = value;
        }

        [DisplayName("Booking Type"), NotNull, ForeignKey("[dbo].[BookingTypes]", "Id"), LeftJoin("jBookingType"), TextualField("BookingType")]
        [LookupEditor(typeof(BookingTypesRow))]
        public Int64? BookingTypeId
        {
            get => fields.BookingTypeId[this];
            set => fields.BookingTypeId[this] = value;
        }

        [DisplayName("Booking Reference"), ForeignKey("[dbo].[BookingSoruces]", "Id"), LeftJoin("jBookingReference"), TextualField("BookingReferenceBookingSoruce")]
        [LookupEditor(typeof(BookingSorucesRow))]
        public Int64? BookingReferenceId
        {
            get => fields.BookingReferenceId[this];
            set => fields.BookingReferenceId[this] = value;
        }

        [DisplayName("Choose Booking Reference"), Size(50)]
        public String ChooseBookingReference
        {
            get => fields.ChooseBookingReference[this];
            set => fields.ChooseBookingReference[this] = value;
        }

        [DisplayName("Purpose Of Visit"), Size(4000)]
        public String PurposeOfVisit
        {
            get => fields.PurposeOfVisit[this];
            set => fields.PurposeOfVisit[this] = value;
        }

        [DisplayName("Remarks"), Size(1073741823)]
        public String Remarks
        {
            get => fields.Remarks[this];
            set => fields.Remarks[this] = value;
        }

        [DisplayName("Booking Charge"), NotNull]
        public Double? BookingCharge
        {
            get => fields.BookingCharge[this];
            set => fields.BookingCharge[this] = value;
        }

        [DisplayName("Tax"), NotNull]
        public Double? Tax
        {
            get => fields.Tax[this];
            set => fields.Tax[this] = value;
        }

        [DisplayName("Service Charge"), NotNull]
        public Double? ServiceCharge
        {
            get => fields.ServiceCharge[this];
            set => fields.ServiceCharge[this] = value;
        }

        [DisplayName("Total"), NotNull]
        public Double? Total
        {
            get => fields.Total[this];
            set => fields.Total[this] = value;
        }

        [DisplayName("Customer Name"), Expression("jCustomer.[Name]")]
        public String CustomerName
        {
            get => fields.CustomerName[this];
            set => fields.CustomerName[this] = value;
        }

        [DisplayName("Customer Contact Name"), Expression("jCustomer.[ContactName]")]
        public String CustomerContactName
        {
            get => fields.CustomerContactName[this];
            set => fields.CustomerContactName[this] = value;
        }

        [DisplayName("Customer Contact Title"), Expression("jCustomer.[ContactTitle]")]
        public String CustomerContactTitle
        {
            get => fields.CustomerContactTitle[this];
            set => fields.CustomerContactTitle[this] = value;
        }

        [DisplayName("Customer Country Id"), Expression("jCustomer.[CountryId]")]
        public Int64? CustomerCountryId
        {
            get => fields.CustomerCountryId[this];
            set => fields.CustomerCountryId[this] = value;
        }

        [DisplayName("Customer State Id"), Expression("jCustomer.[StateId]")]
        public Int64? CustomerStateId
        {
            get => fields.CustomerStateId[this];
            set => fields.CustomerStateId[this] = value;
        }

        [DisplayName("Customer City Id"), Expression("jCustomer.[CityId]")]
        public Int64? CustomerCityId
        {
            get => fields.CustomerCityId[this];
            set => fields.CustomerCityId[this] = value;
        }

        [DisplayName("Customer Address"), Expression("jCustomer.[Address]")]
        public String CustomerAddress
        {
            get => fields.CustomerAddress[this];
            set => fields.CustomerAddress[this] = value;
        }

        [DisplayName("Customer Region Id"), Expression("jCustomer.[RegionId]")]
        public Int64? CustomerRegionId
        {
            get => fields.CustomerRegionId[this];
            set => fields.CustomerRegionId[this] = value;
        }

        [DisplayName("Customer Postal Code"), Expression("jCustomer.[PostalCode]")]
        public String CustomerPostalCode
        {
            get => fields.CustomerPostalCode[this];
            set => fields.CustomerPostalCode[this] = value;
        }

        [DisplayName("Customer Phone"), Expression("jCustomer.[Phone]")]
        public String CustomerPhone
        {
            get => fields.CustomerPhone[this];
            set => fields.CustomerPhone[this] = value;
        }

        [DisplayName("Customer Fax"), Expression("jCustomer.[Fax]")]
        public String CustomerFax
        {
            get => fields.CustomerFax[this];
            set => fields.CustomerFax[this] = value;
        }

        [DisplayName("Customer Website"), Expression("jCustomer.[Website]")]
        public String CustomerWebsite
        {
            get => fields.CustomerWebsite[this];
            set => fields.CustomerWebsite[this] = value;
        }

        [DisplayName("Customer Email"), Expression("jCustomer.[Email]")]
        public String CustomerEmail
        {
            get => fields.CustomerEmail[this];
            set => fields.CustomerEmail[this] = value;
        }

        [DisplayName("Customer Email Address"), Expression("jCustomer.[EmailAddress]")]
        public String CustomerEmailAddress
        {
            get => fields.CustomerEmailAddress[this];
            set => fields.CustomerEmailAddress[this] = value;
        }

        [DisplayName("Customer Previous Credit Balance"), Expression("jCustomer.[PreviousCreditBalance]")]
        public Double? CustomerPreviousCreditBalance
        {
            get => fields.CustomerPreviousCreditBalance[this];
            set => fields.CustomerPreviousCreditBalance[this] = value;
        }

        [DisplayName("Customer Insert Date"), Expression("jCustomer.[InsertDate]")]
        public DateTime? CustomerInsertDate
        {
            get => fields.CustomerInsertDate[this];
            set => fields.CustomerInsertDate[this] = value;
        }

        [DisplayName("Customer Insert User Id"), Expression("jCustomer.[InsertUserId]")]
        public Int32? CustomerInsertUserId
        {
            get => fields.CustomerInsertUserId[this];
            set => fields.CustomerInsertUserId[this] = value;
        }

        [DisplayName("Customer Update Date"), Expression("jCustomer.[UpdateDate]")]
        public DateTime? CustomerUpdateDate
        {
            get => fields.CustomerUpdateDate[this];
            set => fields.CustomerUpdateDate[this] = value;
        }

        [DisplayName("Customer Update User Id"), Expression("jCustomer.[UpdateUserId]")]
        public Int32? CustomerUpdateUserId
        {
            get => fields.CustomerUpdateUserId[this];
            set => fields.CustomerUpdateUserId[this] = value;
        }

        [DisplayName("Customer Delete Date"), Expression("jCustomer.[DeleteDate]")]
        public DateTime? CustomerDeleteDate
        {
            get => fields.CustomerDeleteDate[this];
            set => fields.CustomerDeleteDate[this] = value;
        }

        [DisplayName("Customer Delete User Id"), Expression("jCustomer.[DeleteUserId]")]
        public Int32? CustomerDeleteUserId
        {
            get => fields.CustomerDeleteUserId[this];
            set => fields.CustomerDeleteUserId[this] = value;
        }

        [DisplayName("Customer Is Active"), Expression("jCustomer.[IsActive]")]
        public Int32? CustomerIsActive
        {
            get => fields.CustomerIsActive[this];
            set => fields.CustomerIsActive[this] = value;
        }

        [DisplayName("Customer Customer Group Id"), Expression("jCustomer.[CustomerGroupId]")]
        public Int64? CustomerCustomerGroupId
        {
            get => fields.CustomerCustomerGroupId[this];
            set => fields.CustomerCustomerGroupId[this] = value;
        }

        [DisplayName("Customer Cnic"), Expression("jCustomer.[CNIC]")]
        public String CustomerCnic
        {
            get => fields.CustomerCnic[this];
            set => fields.CustomerCnic[this] = value;
        }

        [DisplayName("Customer Ntn"), Expression("jCustomer.[NTN]")]
        public String CustomerNtn
        {
            get => fields.CustomerNtn[this];
            set => fields.CustomerNtn[this] = value;
        }

        [DisplayName("Customer Strn"), Expression("jCustomer.[STRN]")]
        public String CustomerStrn
        {
            get => fields.CustomerStrn[this];
            set => fields.CustomerStrn[this] = value;
        }

        [DisplayName("Customer Sales Man"), Expression("jCustomer.[SalesMan]")]
        public Int64? CustomerSalesMan
        {
            get => fields.CustomerSalesMan[this];
            set => fields.CustomerSalesMan[this] = value;
        }

        [DisplayName("Customer Vat"), Expression("jCustomer.[Vat]")]
        public String CustomerVat
        {
            get => fields.CustomerVat[this];
            set => fields.CustomerVat[this] = value;
        }

        [DisplayName("Customer Order Booker"), Expression("jCustomer.[OrderBooker]")]
        public Int64? CustomerOrderBooker
        {
            get => fields.CustomerOrderBooker[this];
            set => fields.CustomerOrderBooker[this] = value;
        }

        [DisplayName("Booking Type"), Expression("jBookingType.[BookingType]")]
        public String BookingType
        {
            get => fields.BookingType[this];
            set => fields.BookingType[this] = value;
        }

        [DisplayName("Booking Reference Booking Type Id"), Expression("jBookingReference.[BookingTypeId]")]
        public Int64? BookingReferenceBookingTypeId
        {
            get => fields.BookingReferenceBookingTypeId[this];
            set => fields.BookingReferenceBookingTypeId[this] = value;
        }

        [DisplayName("Booking Reference Booking Soruce"), Expression("jBookingReference.[BookingSoruce]")]
        public String BookingReferenceBookingSoruce
        {
            get => fields.BookingReferenceBookingSoruce[this];
            set => fields.BookingReferenceBookingSoruce[this] = value;
        }

        [DisplayName("Booking Reference Commission Rate"), Expression("jBookingReference.[CommissionRate]")]
        public Double? BookingReferenceCommissionRate
        {
            get => fields.BookingReferenceCommissionRate[this];
            set => fields.BookingReferenceCommissionRate[this] = value;
        }

        [DisplayName("Room List"), MasterDetailRelation(foreignKey: "RoomReservationId"), NotMapped]
        public List<RoomReservationDetailsRow> RoomList
        {
            get => fields.RoomList[this];
            set => fields.RoomList[this] = value;
        }

        public RoomReservationsRow()
            : base()
        {
        }

        public RoomReservationsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field CustomerId;
            public DateTimeField CheckIn;
            public DateTimeField CheckOut;
            public StringField ArivalFrom;
            public Int64Field BookingTypeId;
            public Int64Field BookingReferenceId;
            public StringField ChooseBookingReference;
            public StringField PurposeOfVisit;
            public StringField Remarks;
            public DoubleField BookingCharge;
            public DoubleField Tax;
            public DoubleField ServiceCharge;
            public DoubleField Total;

            public StringField CustomerName;
            public StringField CustomerContactName;
            public StringField CustomerContactTitle;
            public Int64Field CustomerCountryId;
            public Int64Field CustomerStateId;
            public Int64Field CustomerCityId;
            public StringField CustomerAddress;
            public Int64Field CustomerRegionId;
            public StringField CustomerPostalCode;
            public StringField CustomerPhone;
            public StringField CustomerFax;
            public StringField CustomerWebsite;
            public StringField CustomerEmail;
            public StringField CustomerEmailAddress;
            public DoubleField CustomerPreviousCreditBalance;
            public DateTimeField CustomerInsertDate;
            public Int32Field CustomerInsertUserId;
            public DateTimeField CustomerUpdateDate;
            public Int32Field CustomerUpdateUserId;
            public DateTimeField CustomerDeleteDate;
            public Int32Field CustomerDeleteUserId;
            public Int32Field CustomerIsActive;
            public Int64Field CustomerCustomerGroupId;
            public StringField CustomerCnic;
            public StringField CustomerNtn;
            public StringField CustomerStrn;
            public Int64Field CustomerSalesMan;
            public StringField CustomerVat;
            public Int64Field CustomerOrderBooker;

            public StringField BookingType;

            public Int64Field BookingReferenceBookingTypeId;
            public StringField BookingReferenceBookingSoruce;
            public DoubleField BookingReferenceCommissionRate;

            public RowListField<RoomReservationDetailsRow> RoomList;
        }
    }
}
