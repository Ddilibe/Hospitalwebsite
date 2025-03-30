namespace SmartERP.Masters {
    export interface DeductionsRow {
        Id?: number;
        Name?: string;
        Description?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
        DeleteUserId?: number;
        DeleteDate?: string;
        IsActive?: number;
    }

    export namespace DeductionsRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Masters.Deductions';
        export const lookupKey = 'Masters.Deductions';

        export function getLookup(): Q.Lookup<DeductionsRow> {
            return Q.getLookup<DeductionsRow>('Masters.Deductions');
        }
        export const deletePermission = 'Masters:Deductions:Delete';
        export const insertPermission = 'Masters:Deductions:Create';
        export const readPermission = 'Masters:Deductions:View';
        export const updatePermission = 'Masters:Deductions:Update';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate",
            DeleteUserId = "DeleteUserId",
            DeleteDate = "DeleteDate",
            IsActive = "IsActive"
        }
    }
}
