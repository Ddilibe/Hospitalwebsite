namespace SmartERP.RoomSettings {
    export interface BookingSorucesRow {
        Id?: number;
        BookingTypeId?: number;
        BookingSoruce?: string;
        CommissionRate?: number;
        BookingType?: string;
    }

    export namespace BookingSorucesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'BookingSoruce';
        export const localTextPrefix = 'RoomSettings.BookingSoruces';
        export const lookupKey = 'RoomSettings.BookingSoruces';

        export function getLookup(): Q.Lookup<BookingSorucesRow> {
            return Q.getLookup<BookingSorucesRow>('RoomSettings.BookingSoruces');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            BookingTypeId = "BookingTypeId",
            BookingSoruce = "BookingSoruce",
            CommissionRate = "CommissionRate",
            BookingType = "BookingType"
        }
    }
}
