namespace SmartERP.RoomSettings {
    export interface BookingTypesRow {
        Id?: number;
        BookingType?: string;
    }

    export namespace BookingTypesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'BookingType';
        export const localTextPrefix = 'RoomSettings.BookingTypes';
        export const lookupKey = 'RoomSettings.BookingTypes';

        export function getLookup(): Q.Lookup<BookingTypesRow> {
            return Q.getLookup<BookingTypesRow>('RoomSettings.BookingTypes');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            BookingType = "BookingType"
        }
    }
}
