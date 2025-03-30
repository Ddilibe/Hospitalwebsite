namespace SmartERP.Payroll {
    export interface PayrollForm {
        Number: Serenity.StringEditor;
        PaymentDate: Serenity.DateEditor;
        CashBankId: Serenity.LookupEditor;
        Description: Serenity.StringEditor;
        ItemList: PayrollDetailEditor;
        CurrencyName: Serenity.StringEditor;
        TotalBasicSalary: Serenity.DecimalEditor;
        TotalIncome: Serenity.DecimalEditor;
        TotalDeduction: Serenity.DecimalEditor;
        TotalTakeHomePay: Serenity.DecimalEditor;
        TotalPaymentAmount: Serenity.DecimalEditor;
    }

    export class PayrollForm extends Serenity.PrefixedContext {
        static formKey = 'Payroll.Payroll';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PayrollForm.init)  {
                PayrollForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.LookupEditor;
                var w3 = PayrollDetailEditor;
                var w4 = s.DecimalEditor;

                Q.initFormType(PayrollForm, [
                    'Number', w0,
                    'PaymentDate', w1,
                    'CashBankId', w2,
                    'Description', w0,
                    'ItemList', w3,
                    'CurrencyName', w0,
                    'TotalBasicSalary', w4,
                    'TotalIncome', w4,
                    'TotalDeduction', w4,
                    'TotalTakeHomePay', w4,
                    'TotalPaymentAmount', w4
                ]);
            }
        }
    }
}
