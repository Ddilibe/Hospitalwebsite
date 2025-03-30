namespace SmartERP.RoomSettings {
    export interface RoomsForm {
        RoomTypeId: Serenity.LookupEditor;
        RoomNo: Serenity.IntegerEditor;
        Capacity: Serenity.IntegerEditor;
        ExtraCapability: Serenity.IntegerEditor;
        Rate: Serenity.DecimalEditor;
        BedCharge: Serenity.DecimalEditor;
        PersonCharge: Serenity.DecimalEditor;
        RoomSize: Serenity.IntegerEditor;
        RoomSizeType: Serenity.LookupEditor;
        BedNo: Serenity.IntegerEditor;
        BedType: Serenity.LookupEditor;
        RoomDrescription: Serenity.TextAreaEditor;
        ReserveCondition: Serenity.TextAreaEditor;
    }

    export class RoomsForm extends Serenity.PrefixedContext {
        static formKey = 'RoomSettings.Rooms';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RoomsForm.init)  {
                RoomsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.TextAreaEditor;

                Q.initFormType(RoomsForm, [
                    'RoomTypeId', w0,
                    'RoomNo', w1,
                    'Capacity', w1,
                    'ExtraCapability', w1,
                    'Rate', w2,
                    'BedCharge', w2,
                    'PersonCharge', w2,
                    'RoomSize', w1,
                    'RoomSizeType', w0,
                    'BedNo', w1,
                    'BedType', w0,
                    'RoomDrescription', w3,
                    'ReserveCondition', w3
                ]);
            }
        }
    }
}
