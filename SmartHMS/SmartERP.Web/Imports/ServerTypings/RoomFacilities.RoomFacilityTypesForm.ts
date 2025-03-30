namespace SmartERP.RoomFacilities {
    export interface RoomFacilityTypesForm {
        Name: Serenity.StringEditor;
    }

    export class RoomFacilityTypesForm extends Serenity.PrefixedContext {
        static formKey = 'RoomFacilities.RoomFacilityTypes';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RoomFacilityTypesForm.init)  {
                RoomFacilityTypesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(RoomFacilityTypesForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
