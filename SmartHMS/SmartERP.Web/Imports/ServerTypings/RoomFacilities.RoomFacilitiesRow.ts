namespace SmartERP.RoomFacilities {
    export interface RoomFacilitiesRow {
        Id?: number;
        FacilityType?: number;
        FacilityName?: string;
        Image?: string;
        FacilityTypeName?: string;
    }

    export namespace RoomFacilitiesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'FacilityName';
        export const localTextPrefix = 'RoomFacilities.RoomFacilities';
        export const lookupKey = 'RoomFacilities.RoomFacilities';

        export function getLookup(): Q.Lookup<RoomFacilitiesRow> {
            return Q.getLookup<RoomFacilitiesRow>('RoomFacilities.RoomFacilities');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            FacilityType = "FacilityType",
            FacilityName = "FacilityName",
            Image = "Image",
            FacilityTypeName = "FacilityTypeName"
        }
    }
}
