namespace SmartERP.RoomFacilities {
    export interface RoomFacilityTypesRow {
        Id?: number;
        Name?: string;
    }

    export namespace RoomFacilityTypesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'RoomFacilities.RoomFacilityTypes';
        export const lookupKey = 'RoomFacilities.RoomFacilityTypes';

        export function getLookup(): Q.Lookup<RoomFacilityTypesRow> {
            return Q.getLookup<RoomFacilityTypesRow>('RoomFacilities.RoomFacilityTypes');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name"
        }
    }
}
