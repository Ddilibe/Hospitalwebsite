namespace SmartERP.RoomSettings {
    export interface BedTypesForm {
        Name: Serenity.StringEditor;
    }

    export class BedTypesForm extends Serenity.PrefixedContext {
        static formKey = 'RoomSettings.BedTypes';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BedTypesForm.init)  {
                BedTypesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(BedTypesForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
