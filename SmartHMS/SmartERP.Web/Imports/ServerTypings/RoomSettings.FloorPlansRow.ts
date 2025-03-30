namespace SmartERP.RoomSettings {
    export interface FloorPlansRow {
        Id?: number;
        Floor?: number;
        StartRoomNo?: number;
        NoOfRoom?: number;
        FloorName?: string;
    }

    export namespace FloorPlansRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'RoomSettings.FloorPlans';
        export const lookupKey = 'RoomSettings.FloorPlans';

        export function getLookup(): Q.Lookup<FloorPlansRow> {
            return Q.getLookup<FloorPlansRow>('RoomSettings.FloorPlans');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Floor = "Floor",
            StartRoomNo = "StartRoomNo",
            NoOfRoom = "NoOfRoom",
            FloorName = "FloorName"
        }
    }
}
