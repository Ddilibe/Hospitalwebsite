namespace SmartERP.RoomSettings {
    export interface RoomTypesForm {
        RoomType: Serenity.StringEditor;
    }

    export class RoomTypesForm extends Serenity.PrefixedContext {
        static formKey = 'RoomSettings.RoomTypes';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RoomTypesForm.init)  {
                RoomTypesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(RoomTypesForm, [
                    'RoomType', w0
                ]);
            }
        }
    }
}
