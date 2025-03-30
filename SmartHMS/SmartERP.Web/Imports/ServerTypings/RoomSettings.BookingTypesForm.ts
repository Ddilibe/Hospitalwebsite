namespace SmartERP.RoomSettings {
    export interface BookingTypesForm {
        BookingType: Serenity.StringEditor;
    }

    export class BookingTypesForm extends Serenity.PrefixedContext {
        static formKey = 'RoomSettings.BookingTypes';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BookingTypesForm.init)  {
                BookingTypesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(BookingTypesForm, [
                    'BookingType', w0
                ]);
            }
        }
    }
}
