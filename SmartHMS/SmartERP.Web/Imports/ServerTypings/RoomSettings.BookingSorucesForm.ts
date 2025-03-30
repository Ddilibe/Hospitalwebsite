namespace SmartERP.RoomSettings {
    export interface BookingSorucesForm {
        BookingTypeId: Serenity.LookupEditor;
        BookingSoruce: Serenity.StringEditor;
        CommissionRate: Serenity.DecimalEditor;
    }

    export class BookingSorucesForm extends Serenity.PrefixedContext {
        static formKey = 'RoomSettings.BookingSoruces';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BookingSorucesForm.init)  {
                BookingSorucesForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DecimalEditor;

                Q.initFormType(BookingSorucesForm, [
                    'BookingTypeId', w0,
                    'BookingSoruce', w1,
                    'CommissionRate', w2
                ]);
            }
        }
    }
}
