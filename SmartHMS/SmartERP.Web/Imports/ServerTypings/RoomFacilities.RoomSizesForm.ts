namespace SmartERP.RoomFacilities {
    export interface RoomSizesForm {
        Name: Serenity.StringEditor;
    }

    export class RoomSizesForm extends Serenity.PrefixedContext {
        static formKey = 'RoomFacilities.RoomSizes';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RoomSizesForm.init)  {
                RoomSizesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(RoomSizesForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
