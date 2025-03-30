namespace SmartERP.Payroll {
    export interface PayrollDetailForm {
        Id: Serenity.StringEditor;
        EmployeeId: Serenity.LookupEditor;
        BankAccount: Serenity.StringEditor;
        BankName: Serenity.StringEditor;
        BasicSalary: Serenity.DecimalEditor;
        IncomeList: PayrollDetailIncomeEditor;
        DeductionList: PayrollDetailDeductionEditor;
        TotalIncome: Serenity.DecimalEditor;
        TotalDeduction: Serenity.DecimalEditor;
        TakeHomePay: Serenity.DecimalEditor;
    }

    export class PayrollDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Payroll.PayrollDetail';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PayrollDetailForm.init)  {
                PayrollDetailForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.DecimalEditor;
                var w3 = PayrollDetailIncomeEditor;
                var w4 = PayrollDetailDeductionEditor;

                Q.initFormType(PayrollDetailForm, [
                    'Id', w0,
                    'EmployeeId', w1,
                    'BankAccount', w0,
                    'BankName', w0,
                    'BasicSalary', w2,
                    'IncomeList', w3,
                    'DeductionList', w4,
                    'TotalIncome', w2,
                    'TotalDeduction', w2,
                    'TakeHomePay', w2
                ]);
            }
        }
    }
}
