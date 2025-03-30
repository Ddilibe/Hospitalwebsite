
namespace SmartERP.HumanResource {

    @Serenity.Decorators.registerClass()
    export class EmployeeIncomesDialog extends Serenity.Extensions.GridEditorDialog<EmployeeIncomesRow> {
        protected getFormKey() { return EmployeeIncomesForm.formKey; }
        protected getIdProperty() { return EmployeeIncomesRow.idProperty; }
        protected getLocalTextPrefix() { return EmployeeIncomesRow.localTextPrefix; }
        protected getNameProperty() { return EmployeeIncomesRow.nameProperty; }
        protected getService() { return EmployeeIncomesService.baseUrl; }
        protected getDeletePermission() { return EmployeeIncomesRow.deletePermission; }
        protected getInsertPermission() { return EmployeeIncomesRow.insertPermission; }
        protected getUpdatePermission() { return EmployeeIncomesRow.updatePermission; }

        protected form = new EmployeeIncomesForm(this.idPrefix);

    }
}