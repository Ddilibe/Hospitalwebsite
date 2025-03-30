namespace SmartERP.Masters {
    export interface IncomesRow {
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

    export namespace IncomesRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Masters.Incomes';
        export const lookupKey = 'Masters.Incomes';

        export function getLookup(): Q.Lookup<IncomesRow> {
            return Q.getLookup<IncomesRow>('Masters.Incomes');
        }
        export const deletePermission = 'Masters:Incomes:Delete';
        export const insertPermission = 'Masters:Incomes:Create';
        export const readPermission = 'Masters:Incomes:View';
        export const updatePermission = 'Masters:Incomes:Update';

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
