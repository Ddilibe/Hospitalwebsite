namespace SmartERP.RoomSettings {
    export interface RoomImagesRow {
        Id?: number;
        RoomType?: number;
        Image?: string;
        RoomType1?: string;
    }

    export namespace RoomImagesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Image';
        export const localTextPrefix = 'RoomSettings.RoomImages';
        export const lookupKey = 'RoomSettings.RoomImages';

        export function getLookup(): Q.Lookup<RoomImagesRow> {
            return Q.getLookup<RoomImagesRow>('RoomSettings.RoomImages');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            RoomType = "RoomType",
            Image = "Image",
            RoomType1 = "RoomType1"
        }
    }
}
