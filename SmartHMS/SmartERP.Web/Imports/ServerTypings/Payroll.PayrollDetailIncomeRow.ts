namespace SmartERP.Payroll {
    export interface PayrollDetailIncomeRow {
        Id?: number;
        PayrollDetailId?: number;
        IncomeId?: number;
        ShortNote?: string;
        Amount?: number;
        IncomeName?: string;
    }

    export namespace PayrollDetailIncomeRow {
        export const idProperty = 'Id';
        export const nameProperty = 'IncomeName';
        export const localTextPrefix = 'Payroll.PayrollDetailIncome';
        export const deletePermission = 'Human Resource:Payroll:Delete';
        export const insertPermission = 'Human Resource:Payroll:Create';
        export const readPermission = 'Human Resource:Payroll:View';
        export const updatePermission = 'Human Resource:Payroll:Update';

        export declare const enum Fields {
            Id = "Id",
            PayrollDetailId = "PayrollDetailId",
            IncomeId = "IncomeId",
            ShortNote = "ShortNote",
            Amount = "Amount",
            IncomeName = "IncomeName"
        }
    }
}
