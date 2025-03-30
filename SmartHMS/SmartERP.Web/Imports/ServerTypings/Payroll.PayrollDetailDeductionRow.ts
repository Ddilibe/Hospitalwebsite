namespace SmartERP.Payroll {
    export interface PayrollDetailDeductionRow {
        Id?: number;
        PayrollDetailId?: number;
        DeductionId?: number;
        ShortNote?: string;
        Amount?: number;
        DeductionName?: string;
    }

    export namespace PayrollDetailDeductionRow {
        export const idProperty = 'Id';
        export const nameProperty = 'DeductionName';
        export const localTextPrefix = 'Payroll.PayrollDetailDeduction';
        export const deletePermission = 'Human Resource:Payroll:Delete';
        export const insertPermission = 'Human Resource:Payroll:Create';
        export const readPermission = 'Human Resource:Payroll:View';
        export const updatePermission = 'Human Resource:Payroll:Update';

        export declare const enum Fields {
            Id = "Id",
            PayrollDetailId = "PayrollDetailId",
            DeductionId = "DeductionId",
            ShortNote = "ShortNote",
            Amount = "Amount",
            DeductionName = "DeductionName"
        }
    }
}
