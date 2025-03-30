namespace SmartERP.HumanResource {
    export interface EmployeeBankAccountsForm {
        AccountTitle: Serenity.StringEditor;
        AccountNumber: Serenity.StringEditor;
        BankName: Serenity.LookupEditor;
        BankCode: Serenity.StringEditor;
        BankBranch: Serenity.StringEditor;
    }

    export class EmployeeBankAccountsForm extends Serenity.PrefixedContext {
        static formKey = 'HumanResource.EmployeeBankAccounts';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!EmployeeBankAccountsForm.init)  {
                EmployeeBankAccountsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(EmployeeBankAccountsForm, [
                    'AccountTitle', w0,
                    'AccountNumber', w0,
                    'BankName', w1,
                    'BankCode', w0,
                    'BankBranch', w0
                ]);
            }
        }
    }
}
