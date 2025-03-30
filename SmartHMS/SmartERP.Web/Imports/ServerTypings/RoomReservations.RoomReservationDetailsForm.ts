namespace SmartERP.RoomReservations {
    export interface RoomReservationDetailsForm {
        RoomTypeId: Serenity.LookupEditor;
        RoomNoId: Serenity.LookupEditor;
        Adults: Serenity.IntegerEditor;
        Children: Serenity.IntegerEditor;
        CheckIn: Serenity.DateEditor;
        CheckOut: Serenity.DateEditor;
        Rent: Serenity.DecimalEditor;
    }

    export class RoomReservationDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'RoomReservations.RoomReservationDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RoomReservationDetailsForm.init)  {
                RoomReservationDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;
                var w3 = s.DecimalEditor;

                Q.initFormType(RoomReservationDetailsForm, [
                    'RoomTypeId', w0,
                    'RoomNoId', w0,
                    'Adults', w1,
                    'Children', w1,
                    'CheckIn', w2,
                    'CheckOut', w2,
                    'Rent', w3
                ]);
            }
        }
    }
}
