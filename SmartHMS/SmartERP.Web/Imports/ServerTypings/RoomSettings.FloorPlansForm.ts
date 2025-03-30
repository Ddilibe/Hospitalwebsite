namespace SmartERP.RoomSettings {
    export interface FloorPlansForm {
        Floor: Serenity.LookupEditor;
        StartRoomNo: Serenity.IntegerEditor;
        NoOfRoom: Serenity.IntegerEditor;
    }

    export class FloorPlansForm extends Serenity.PrefixedContext {
        static formKey = 'RoomSettings.FloorPlans';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!FloorPlansForm.init)  {
                FloorPlansForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(FloorPlansForm, [
                    'Floor', w0,
                    'StartRoomNo', w1,
                    'NoOfRoom', w1
                ]);
            }
        }
    }
}
