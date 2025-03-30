namespace SmartERP.RoomSettings {
    export interface FloorsRow {
        Id?: number;
        Name?: string;
    }

    export namespace FloorsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'RoomSettings.Floors';
        export const lookupKey = 'RoomSettings.Floors';

        export function getLookup(): Q.Lookup<FloorsRow> {
            return Q.getLookup<FloorsRow>('RoomSettings.Floors');
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
