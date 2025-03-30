namespace SmartERP.HumanResource {
    export interface EmployeeIncomesForm {
        IncomeId: Serenity.LookupEditor;
        Amount: Serenity.DecimalEditor;
        Description: Serenity.StringEditor;
    }

    export class EmployeeIncomesForm extends Serenity.PrefixedContext {
        static formKey = 'HumanResource.EmployeeIncomes';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!EmployeeIncomesForm.init)  {
                EmployeeIncomesForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.StringEditor;

                Q.initFormType(EmployeeIncomesForm, [
                    'IncomeId', w0,
                    'Amount', w1,
                    'Description', w2
                ]);
            }
        }
    }
}
