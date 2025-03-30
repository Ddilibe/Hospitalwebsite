namespace SmartERP.RoomSettings {
    export interface RoomImagesForm {
        RoomType: Serenity.LookupEditor;
        Image: Serenity.StringEditor;
    }

    export class RoomImagesForm extends Serenity.PrefixedContext {
        static formKey = 'RoomSettings.RoomImages';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RoomImagesForm.init)  {
                RoomImagesForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;

                Q.initFormType(RoomImagesForm, [
                    'RoomType', w0,
                    'Image', w1
                ]);
            }
        }
    }
}
