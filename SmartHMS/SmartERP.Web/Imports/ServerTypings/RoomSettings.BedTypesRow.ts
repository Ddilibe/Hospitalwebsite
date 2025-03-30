namespace SmartERP.RoomSettings {
    export interface BedTypesRow {
        Id?: number;
        Name?: string;
    }

    export namespace BedTypesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'RoomSettings.BedTypes';
        export const lookupKey = 'RoomSettings.BedTypes';

        export function getLookup(): Q.Lookup<BedTypesRow> {
            return Q.getLookup<BedTypesRow>('RoomSettings.BedTypes');
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
