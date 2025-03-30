namespace SmartERP.Masters {
    export interface DeductionsForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    export class DeductionsForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.Deductions';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DeductionsForm.init)  {
                DeductionsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(DeductionsForm, [
                    'Name', w0,
                    'Description', w0
                ]);
            }
        }
    }
}
