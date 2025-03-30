namespace SmartERP.Payroll {
    export interface PayrollRow {
        Id?: number;
        Number?: string;
        Description?: string;
        PaymentDate?: string;
        CashBankId?: number;
        TotalBasicSalary?: number;
        TotalIncome?: number;
        TotalDeduction?: number;
        TotalTakeHomePay?: number;
        TotalPaymentAmount?: number;
        ItemList?: PayrollDetailRow[];
        CashBankName?: string;
        CurrencyName?: string;
    }

    export namespace PayrollRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Number';
        export const localTextPrefix = 'Payroll.Payroll';
        export const deletePermission = 'Human Resource:Payroll:Delete';
        export const insertPermission = 'Human Resource:Payroll:Create';
        export const readPermission = 'Human Resource:Payroll:View';
        export const updatePermission = 'Human Resource:Payroll:Update';

        export declare const enum Fields {
            Id = "Id",
            Number = "Number",
            Description = "Description",
            PaymentDate = "PaymentDate",
            CashBankId = "CashBankId",
            TotalBasicSalary = "TotalBasicSalary",
            TotalIncome = "TotalIncome",
            TotalDeduction = "TotalDeduction",
            TotalTakeHomePay = "TotalTakeHomePay",
            TotalPaymentAmount = "TotalPaymentAmount",
            ItemList = "ItemList",
            CashBankName = "CashBankName",
            CurrencyName = "CurrencyName"
        }
    }
}
