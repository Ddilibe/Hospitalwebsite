namespace SmartERP.HumanResource {
    export interface EmployeeDeductionsForm {
        DeductionId: Serenity.LookupEditor;
        Amount: Serenity.DecimalEditor;
        Description: Serenity.StringEditor;
    }

    export class EmployeeDeductionsForm extends Serenity.PrefixedContext {
        static formKey = 'HumanResource.EmployeeDeductions';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!EmployeeDeductionsForm.init)  {
                EmployeeDeductionsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.StringEditor;

                Q.initFormType(EmployeeDeductionsForm, [
                    'DeductionId', w0,
                    'Amount', w1,
                    'Description', w2
                ]);
            }
        }
    }
}
