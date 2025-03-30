namespace SmartERP.Payroll {
    export interface PayrollDetailRow {
        Id?: number;
        PayrollId?: number;
        EmployeeId?: number;
        BankAccount?: string;
        BankName?: string;
        BasicSalary?: number;
        TotalIncome?: number;
        TotalDeduction?: number;
        TakeHomePay?: number;
        EmployeeFullName?: string;
        IncomeList?: PayrollDetailIncomeRow[];
        DeductionList?: PayrollDetailDeductionRow[];
    }

    export namespace PayrollDetailRow {
        export const idProperty = 'Id';
        export const nameProperty = 'BankAccount';
        export const localTextPrefix = 'Payroll.PayrollDetail';
        export const deletePermission = 'Human Resource:Payroll:Delete';
        export const insertPermission = 'Human Resource:Payroll:Create';
        export const readPermission = 'Human Resource:Payroll:View';
        export const updatePermission = 'Human Resource:Payroll:Update';

        export declare const enum Fields {
            Id = "Id",
            PayrollId = "PayrollId",
            EmployeeId = "EmployeeId",
            BankAccount = "BankAccount",
            BankName = "BankName",
            BasicSalary = "BasicSalary",
            TotalIncome = "TotalIncome",
            TotalDeduction = "TotalDeduction",
            TakeHomePay = "TakeHomePay",
            EmployeeFullName = "EmployeeFullName",
            IncomeList = "IncomeList",
            DeductionList = "DeductionList"
        }
    }
}
