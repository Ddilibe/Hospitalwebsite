
namespace SmartERP.Payroll {

    @Serenity.Decorators.registerClass()
    export class PayrollDetailIncomeDialog extends Serenity.Extensions.GridEditorDialog<PayrollDetailIncomeRow> {
        protected getFormKey() { return PayrollDetailIncomeForm.formKey; }
        protected getIdProperty() { return PayrollDetailIncomeRow.idProperty; }
        protected getLocalTextPrefix() { return PayrollDetailIncomeRow.localTextPrefix; }
        protected getNameProperty() { return PayrollDetailIncomeRow.nameProperty; }
        protected getService() { return PayrollDetailIncomeService.baseUrl; }
        protected getDeletePermission() { return PayrollDetailIncomeRow.deletePermission; }
        protected getInsertPermission() { return PayrollDetailIncomeRow.insertPermission; }
        protected getUpdatePermission() { return PayrollDetailIncomeRow.updatePermission; }

        protected form = new PayrollDetailIncomeForm(this.idPrefix);

    }
}