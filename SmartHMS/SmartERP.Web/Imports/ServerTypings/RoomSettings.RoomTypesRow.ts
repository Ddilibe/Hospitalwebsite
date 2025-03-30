namespace SmartERP.RoomSettings {
    export interface RoomTypesRow {
        Id?: number;
        RoomType?: string;
    }

    export namespace RoomTypesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'RoomType';
        export const localTextPrefix = 'RoomSettings.RoomTypes';
        export const lookupKey = 'RoomSettings.RoomTypes';

        export function getLookup(): Q.Lookup<RoomTypesRow> {
            return Q.getLookup<RoomTypesRow>('RoomSettings.RoomTypes');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            RoomType = "RoomType"
        }
    }
}
