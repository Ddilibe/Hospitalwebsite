namespace SmartERP.HumanResource {
    export interface EmployeeBankAccountsRow {
        Id?: number;
        Employee?: number;
        AccountTitle?: string;
        AccountNumber?: string;
        BankName?: number;
        BankCode?: string;
        BankBranch?: string;
        EmployeeFirstName?: string;
        EmployeeLastName?: string;
        EmployeeEmployeeCode?: number;
        EmployeeDateOfJoining?: string;
        EmployeeCompany?: number;
        EmployeeLocation?: number;
        EmployeeDepartment?: number;
        EmployeeDesignation?: number;
        EmployeeUsername?: number;
        EmployeeEmail?: string;
        EmployeeGender?: number;
        EmployeeOfficeShift?: number;
        EmployeeDateOfBirth?: string;
        EmployeeContactNumber?: string;
        EmployeeReportsTo?: number;
        EmployeePinCode?: number;
        EmployeeAddress?: string;
        EmployeePhoto?: string;
        BankName1?: string;
    }

    export namespace EmployeeBankAccountsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'AccountTitle';
        export const localTextPrefix = 'HumanResource.EmployeeBankAccounts';
        export const lookupKey = 'HumanResource.EmployeeBankAccounts';

        export function getLookup(): Q.Lookup<EmployeeBankAccountsRow> {
            return Q.getLookup<EmployeeBankAccountsRow>('HumanResource.EmployeeBankAccounts');
        }
        export const deletePermission = 'Human Resource:Employee Bank Accounts:Delete';
        export const insertPermission = 'Human Resource:Employee Bank Accounts:Create';
        export const readPermission = 'Human Resource:Employee Bank Accounts:View';
        export const updatePermission = 'Human Resource:Employee Bank Accounts:Update';

        export declare const enum Fields {
            Id = "Id",
            Employee = "Employee",
            AccountTitle = "AccountTitle",
            AccountNumber = "AccountNumber",
            BankName = "BankName",
            BankCode = "BankCode",
            BankBranch = "BankBranch",
            EmployeeFirstName = "EmployeeFirstName",
            EmployeeLastName = "EmployeeLastName",
            EmployeeEmployeeCode = "EmployeeEmployeeCode",
            EmployeeDateOfJoining = "EmployeeDateOfJoining",
            EmployeeCompany = "EmployeeCompany",
            EmployeeLocation = "EmployeeLocation",
            EmployeeDepartment = "EmployeeDepartment",
            EmployeeDesignation = "EmployeeDesignation",
            EmployeeUsername = "EmployeeUsername",
            EmployeeEmail = "EmployeeEmail",
            EmployeeGender = "EmployeeGender",
            EmployeeOfficeShift = "EmployeeOfficeShift",
            EmployeeDateOfBirth = "EmployeeDateOfBirth",
            EmployeeContactNumber = "EmployeeContactNumber",
            EmployeeReportsTo = "EmployeeReportsTo",
            EmployeePinCode = "EmployeePinCode",
            EmployeeAddress = "EmployeeAddress",
            EmployeePhoto = "EmployeePhoto",
            BankName1 = "BankName1"
        }
    }
}
