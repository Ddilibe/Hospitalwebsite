namespace SmartERP.HumanResource {
    export interface EmployeeIncomesRow {
        Id?: number;
        EmployeeId?: number;
        IncomeId?: number;
        Description?: string;
        Amount?: number;
        EmployeeFullName?: string;
        IncomeName?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
        DeleteUserId?: number;
        DeleteDate?: string;
        IsActive?: number;
    }

    export namespace EmployeeIncomesRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'IncomeName';
        export const localTextPrefix = 'HumanResource.EmployeeIncomes';
        export const deletePermission = 'Human Resource:Employee:Delete';
        export const insertPermission = 'Human Resource:Employee:Create';
        export const readPermission = 'Human Resource:Employee:View';
        export const updatePermission = 'Human Resource:Employee:Update';

        export declare const enum Fields {
            Id = "Id",
            EmployeeId = "EmployeeId",
            IncomeId = "IncomeId",
            Description = "Description",
            Amount = "Amount",
            EmployeeFullName = "EmployeeFullName",
            IncomeName = "IncomeName",
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
