namespace SmartERP.RoomSettings {
    export interface FloorsForm {
        Name: Serenity.StringEditor;
    }

    export class FloorsForm extends Serenity.PrefixedContext {
        static formKey = 'RoomSettings.Floors';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!FloorsForm.init)  {
                FloorsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(FloorsForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
