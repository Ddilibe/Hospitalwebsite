namespace SmartERP.RoomSettings {
    export interface ComplementariesForm {
        RoomType: Serenity.LookupEditor;
        Complementary: Serenity.StringEditor;
        Rate: Serenity.DecimalEditor;
    }

    export class ComplementariesForm extends Serenity.PrefixedContext {
        static formKey = 'RoomSettings.Complementaries';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ComplementariesForm.init)  {
                ComplementariesForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DecimalEditor;

                Q.initFormType(ComplementariesForm, [
                    'RoomType', w0,
                    'Complementary', w1,
                    'Rate', w2
                ]);
            }
        }
    }
}
