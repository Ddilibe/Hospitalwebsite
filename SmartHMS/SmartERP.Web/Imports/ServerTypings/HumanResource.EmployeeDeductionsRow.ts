namespace SmartERP.HumanResource {
    export interface EmployeeDeductionsRow {
        Id?: number;
        EmployeeId?: number;
        DeductionId?: number;
        Description?: string;
        Amount?: number;
        EmployeeFullName?: string;
        DeductionName?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
        DeleteUserId?: number;
        DeleteDate?: string;
        IsActive?: number;
    }

    export namespace EmployeeDeductionsRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'DeductionName';
        export const localTextPrefix = 'HumanResource.EmployeeDeductions';
        export const deletePermission = 'Human Resource:Employee:Delete';
        export const insertPermission = 'Human Resource:Employee:Create';
        export const readPermission = 'Human Resource:Employee:View';
        export const updatePermission = 'Human Resource:Employee:Update';

        export declare const enum Fields {
            Id = "Id",
            EmployeeId = "EmployeeId",
            DeductionId = "DeductionId",
            Description = "Description",
            Amount = "Amount",
            EmployeeFullName = "EmployeeFullName",
            DeductionName = "DeductionName",
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
