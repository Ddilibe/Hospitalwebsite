namespace SmartERP.RoomFacilities {
    export interface RoomFacilitiesForm {
        FacilityType: Serenity.LookupEditor;
        FacilityName: Serenity.StringEditor;
        Image: Serenity.ImageUploadEditor;
    }

    export class RoomFacilitiesForm extends Serenity.PrefixedContext {
        static formKey = 'RoomFacilities.RoomFacilities';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RoomFacilitiesForm.init)  {
                RoomFacilitiesForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.ImageUploadEditor;

                Q.initFormType(RoomFacilitiesForm, [
                    'FacilityType', w0,
                    'FacilityName', w1,
                    'Image', w2
                ]);
            }
        }
    }
}
