namespace SmartERP.RoomReservations {
    export interface RoomReservationsRow {
        Id?: number;
        CustomerId?: number;
        CheckIn?: string;
        CheckOut?: string;
        ArivalFrom?: string;
        BookingTypeId?: number;
        BookingReferenceId?: number;
        ChooseBookingReference?: string;
        PurposeOfVisit?: string;
        Remarks?: string;
        BookingCharge?: number;
        Tax?: number;
        ServiceCharge?: number;
        Total?: number;
        CustomerName?: string;
        CustomerContactName?: string;
        CustomerContactTitle?: string;
        CustomerCountryId?: number;
        CustomerStateId?: number;
        CustomerCityId?: number;
        CustomerAddress?: string;
        CustomerRegionId?: number;
        CustomerPostalCode?: string;
        CustomerPhone?: string;
        CustomerFax?: string;
        CustomerWebsite?: string;
        CustomerEmail?: string;
        CustomerEmailAddress?: string;
        CustomerPreviousCreditBalance?: number;
        CustomerInsertDate?: string;
        CustomerInsertUserId?: number;
        CustomerUpdateDate?: string;
        CustomerUpdateUserId?: number;
        CustomerDeleteDate?: string;
        CustomerDeleteUserId?: number;
        CustomerIsActive?: number;
        CustomerCustomerGroupId?: number;
        CustomerCnic?: string;
        CustomerNtn?: string;
        CustomerStrn?: string;
        CustomerSalesMan?: number;
        CustomerVat?: string;
        CustomerOrderBooker?: number;
        BookingType?: string;
        BookingReferenceBookingTypeId?: number;
        BookingReferenceBookingSoruce?: string;
        BookingReferenceCommissionRate?: number;
        RoomList?: RoomReservationDetailsRow[];
    }

    export namespace RoomReservationsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ArivalFrom';
        export const localTextPrefix = 'RoomReservations.RoomReservations';
        export const lookupKey = 'RoomReservations.RoomReservations';

        export function getLookup(): Q.Lookup<RoomReservationsRow> {
            return Q.getLookup<RoomReservationsRow>('RoomReservations.RoomReservations');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            CustomerId = "CustomerId",
            CheckIn = "CheckIn",
            CheckOut = "CheckOut",
            ArivalFrom = "ArivalFrom",
            BookingTypeId = "BookingTypeId",
            BookingReferenceId = "BookingReferenceId",
            ChooseBookingReference = "ChooseBookingReference",
            PurposeOfVisit = "PurposeOfVisit",
            Remarks = "Remarks",
            BookingCharge = "BookingCharge",
            Tax = "Tax",
            ServiceCharge = "ServiceCharge",
            Total = "Total",
            CustomerName = "CustomerName",
            CustomerContactName = "CustomerContactName",
            CustomerContactTitle = "CustomerContactTitle",
            CustomerCountryId = "CustomerCountryId",
            CustomerStateId = "CustomerStateId",
            CustomerCityId = "CustomerCityId",
            CustomerAddress = "CustomerAddress",
            CustomerRegionId = "CustomerRegionId",
            CustomerPostalCode = "CustomerPostalCode",
            CustomerPhone = "CustomerPhone",
            CustomerFax = "CustomerFax",
            CustomerWebsite = "CustomerWebsite",
            CustomerEmail = "CustomerEmail",
            CustomerEmailAddress = "CustomerEmailAddress",
            CustomerPreviousCreditBalance = "CustomerPreviousCreditBalance",
            CustomerInsertDate = "CustomerInsertDate",
            CustomerInsertUserId = "CustomerInsertUserId",
            CustomerUpdateDate = "CustomerUpdateDate",
            CustomerUpdateUserId = "CustomerUpdateUserId",
            CustomerDeleteDate = "CustomerDeleteDate",
            CustomerDeleteUserId = "CustomerDeleteUserId",
            CustomerIsActive = "CustomerIsActive",
            CustomerCustomerGroupId = "CustomerCustomerGroupId",
            CustomerCnic = "CustomerCnic",
            CustomerNtn = "CustomerNtn",
            CustomerStrn = "CustomerStrn",
            CustomerSalesMan = "CustomerSalesMan",
            CustomerVat = "CustomerVat",
            CustomerOrderBooker = "CustomerOrderBooker",
            BookingType = "BookingType",
            BookingReferenceBookingTypeId = "BookingReferenceBookingTypeId",
            BookingReferenceBookingSoruce = "BookingReferenceBookingSoruce",
            BookingReferenceCommissionRate = "BookingReferenceCommissionRate",
            RoomList = "RoomList"
        }
    }
}
