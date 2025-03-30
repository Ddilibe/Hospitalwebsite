namespace SmartERP.RoomSettings {
    export interface ComplementariesRow {
        Id?: number;
        RoomType?: number;
        Complementary?: string;
        Rate?: number;
        RoomType1?: string;
    }

    export namespace ComplementariesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Complementary';
        export const localTextPrefix = 'RoomSettings.Complementaries';
        export const lookupKey = 'RoomSettings.Complementaries';

        export function getLookup(): Q.Lookup<ComplementariesRow> {
            return Q.getLookup<ComplementariesRow>('RoomSettings.Complementaries');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            RoomType = "RoomType",
            Complementary = "Complementary",
            Rate = "Rate",
            RoomType1 = "RoomType1"
        }
    }
}
