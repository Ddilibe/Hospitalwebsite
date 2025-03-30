namespace SmartERP.RoomReservations {
    export interface RoomReservationsForm {
        CustomerId: Serenity.LookupEditor;
        CheckIn: Serenity.DateEditor;
        CheckOut: Serenity.DateEditor;
        ArivalFrom: Serenity.StringEditor;
        BookingTypeId: Serenity.LookupEditor;
        BookingReferenceId: Serenity.LookupEditor;
        ChooseBookingReference: Serenity.StringEditor;
        PurposeOfVisit: Serenity.StringEditor;
        RoomList: RoomReservationDetailsEditor;
        BookingCharge: Serenity.DecimalEditor;
        Tax: Serenity.DecimalEditor;
        ServiceCharge: Serenity.DecimalEditor;
        Total: Serenity.DecimalEditor;
        Remarks: Serenity.TextAreaEditor;
    }

    export class RoomReservationsForm extends Serenity.PrefixedContext {
        static formKey = 'RoomReservations.RoomReservations';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RoomReservationsForm.init)  {
                RoomReservationsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DateEditor;
                var w2 = s.StringEditor;
                var w3 = RoomReservationDetailsEditor;
                var w4 = s.DecimalEditor;
                var w5 = s.TextAreaEditor;

                Q.initFormType(RoomReservationsForm, [
                    'CustomerId', w0,
                    'CheckIn', w1,
                    'CheckOut', w1,
                    'ArivalFrom', w2,
                    'BookingTypeId', w0,
                    'BookingReferenceId', w0,
                    'ChooseBookingReference', w2,
                    'PurposeOfVisit', w2,
                    'RoomList', w3,
                    'BookingCharge', w4,
                    'Tax', w4,
                    'ServiceCharge', w4,
                    'Total', w4,
                    'Remarks', w5
                ]);
            }
        }
    }
}
