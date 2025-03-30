namespace SmartERP.Masters {
    export interface IncomesForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    export class IncomesForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.Incomes';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!IncomesForm.init)  {
                IncomesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(IncomesForm, [
                    'Name', w0,
                    'Description', w0
                ]);
            }
        }
    }
}
