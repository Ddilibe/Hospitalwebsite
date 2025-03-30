namespace SmartERP.RoomSettings {
    export interface RoomsRow {
        Id?: number;
        RoomTypeId?: number;
        RoomNo?: number;
        Capacity?: number;
        ExtraCapability?: number;
        Rate?: number;
        BedCharge?: number;
        PersonCharge?: number;
        RoomSize?: number;
        RoomSizeType?: number;
        BedNo?: number;
        BedType?: number;
        RoomDrescription?: string;
        ReserveCondition?: string;
        RoomType?: string;
        RoomSizeTypeName?: string;
        BedTypeName?: string;
    }

    export namespace RoomsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'RoomDrescription';
        export const localTextPrefix = 'RoomSettings.Rooms';
        export const lookupKey = 'RoomSettings.Rooms';

        export function getLookup(): Q.Lookup<RoomsRow> {
            return Q.getLookup<RoomsRow>('RoomSettings.Rooms');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            RoomTypeId = "RoomTypeId",
            RoomNo = "RoomNo",
            Capacity = "Capacity",
            ExtraCapability = "ExtraCapability",
            Rate = "Rate",
            BedCharge = "BedCharge",
            PersonCharge = "PersonCharge",
            RoomSize = "RoomSize",
            RoomSizeType = "RoomSizeType",
            BedNo = "BedNo",
            BedType = "BedType",
            RoomDrescription = "RoomDrescription",
            ReserveCondition = "ReserveCondition",
            RoomType = "RoomType",
            RoomSizeTypeName = "RoomSizeTypeName",
            BedTypeName = "BedTypeName"
        }
    }
}
