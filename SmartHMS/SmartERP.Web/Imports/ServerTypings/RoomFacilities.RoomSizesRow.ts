namespace SmartERP.RoomFacilities {
    export interface RoomSizesRow {
        Id?: number;
        Name?: string;
    }

    export namespace RoomSizesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'RoomFacilities.RoomSizes';
        export const lookupKey = 'RoomFacilities.RoomSizes';

        export function getLookup(): Q.Lookup<RoomSizesRow> {
            return Q.getLookup<RoomSizesRow>('RoomFacilities.RoomSizes');
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
