namespace SmartERP.RoomReservations {
    export interface RoomReservationDetailsRow {
        Id?: number;
        RoomReservationId?: number;
        RoomTypeId?: number;
        RoomNoId?: number;
        Adults?: number;
        Children?: number;
        CheckIn?: string;
        CheckOut?: string;
        Rent?: number;
        RoomReservationCustomerId?: number;
        RoomReservationCheckIn?: string;
        RoomReservationCheckOut?: string;
        RoomReservationArivalFrom?: string;
        RoomReservationBookingTypeId?: number;
        RoomReservationBookingReferenceId?: number;
        RoomReservationChooseBookingReference?: string;
        RoomReservationPurposeOfVisit?: string;
        RoomReservationRemarks?: string;
        RoomReservationBookingCharge?: number;
        RoomReservationTax?: number;
        RoomReservationServiceCharge?: number;
        RoomReservationTotal?: number;
        RoomType?: string;
        RoomTypeBookingSoruce?: string;
        RoomNoRoomTypeId?: number;
        RoomNo?: number;
        RoomNoCapacity?: number;
        RoomNoExtraCapability?: number;
        RoomNoRate?: number;
        RoomNoBedCharge?: number;
        RoomNoPersonCharge?: number;
        RoomNoRoomSize?: number;
        RoomNoRoomSizeType?: number;
        RoomNoBedNo?: number;
        RoomNoBedType?: number;
        RoomNoRoomDrescription?: string;
        RoomNoReserveCondition?: string;
        RoomRoomNo?: number;
    }

    export namespace RoomReservationDetailsRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'RoomReservations.RoomReservationDetails';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            RoomReservationId = "RoomReservationId",
            RoomTypeId = "RoomTypeId",
            RoomNoId = "RoomNoId",
            Adults = "Adults",
            Children = "Children",
            CheckIn = "CheckIn",
            CheckOut = "CheckOut",
            Rent = "Rent",
            RoomReservationCustomerId = "RoomReservationCustomerId",
            RoomReservationCheckIn = "RoomReservationCheckIn",
            RoomReservationCheckOut = "RoomReservationCheckOut",
            RoomReservationArivalFrom = "RoomReservationArivalFrom",
            RoomReservationBookingTypeId = "RoomReservationBookingTypeId",
            RoomReservationBookingReferenceId = "RoomReservationBookingReferenceId",
            RoomReservationChooseBookingReference = "RoomReservationChooseBookingReference",
            RoomReservationPurposeOfVisit = "RoomReservationPurposeOfVisit",
            RoomReservationRemarks = "RoomReservationRemarks",
            RoomReservationBookingCharge = "RoomReservationBookingCharge",
            RoomReservationTax = "RoomReservationTax",
            RoomReservationServiceCharge = "RoomReservationServiceCharge",
            RoomReservationTotal = "RoomReservationTotal",
            RoomType = "RoomType",
            RoomTypeBookingSoruce = "RoomTypeBookingSoruce",
            RoomNoRoomTypeId = "RoomNoRoomTypeId",
            RoomNo = "RoomNo",
            RoomNoCapacity = "RoomNoCapacity",
            RoomNoExtraCapability = "RoomNoExtraCapability",
            RoomNoRate = "RoomNoRate",
            RoomNoBedCharge = "RoomNoBedCharge",
            RoomNoPersonCharge = "RoomNoPersonCharge",
            RoomNoRoomSize = "RoomNoRoomSize",
            RoomNoRoomSizeType = "RoomNoRoomSizeType",
            RoomNoBedNo = "RoomNoBedNo",
            RoomNoBedType = "RoomNoBedType",
            RoomNoRoomDrescription = "RoomNoRoomDrescription",
            RoomNoReserveCondition = "RoomNoReserveCondition",
            RoomRoomNo = "RoomRoomNo"
        }
    }
}
