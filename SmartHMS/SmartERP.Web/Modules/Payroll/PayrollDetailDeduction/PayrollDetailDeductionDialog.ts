
namespace SmartERP.Payroll {

    @Serenity.Decorators.registerClass()
    export class PayrollDetailDeductionDialog extends Serenity.Extensions.GridEditorDialog<PayrollDetailDeductionRow> {
        protected getFormKey() { return PayrollDetailDeductionForm.formKey; }
        protected getIdProperty() { return PayrollDetailDeductionRow.idProperty; }
        protected getLocalTextPrefix() { return PayrollDetailDeductionRow.localTextPrefix; }
        protected getNameProperty() { return PayrollDetailDeductionRow.nameProperty; }
        protected getService() { return PayrollDetailDeductionService.baseUrl; }
        protected getDeletePermission() { return PayrollDetailDeductionRow.deletePermission; }
        protected getInsertPermission() { return PayrollDetailDeductionRow.insertPermission; }
        protected getUpdatePermission() { return PayrollDetailDeductionRow.updatePermission; }

        protected form = new PayrollDetailDeductionForm(this.idPrefix);

    }
}