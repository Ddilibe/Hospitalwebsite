
namespace SmartERP.HumanResource {

    @Serenity.Decorators.registerClass()
    export class EmployeeDeductionsDialog extends Serenity.Extensions.GridEditorDialog<EmployeeDeductionsRow> {
        protected getFormKey() { return EmployeeDeductionsForm.formKey; }
        protected getIdProperty() { return EmployeeDeductionsRow.idProperty; }
        protected getLocalTextPrefix() { return EmployeeDeductionsRow.localTextPrefix; }
        protected getNameProperty() { return EmployeeDeductionsRow.nameProperty; }
        protected getService() { return EmployeeDeductionsService.baseUrl; }
        protected getDeletePermission() { return EmployeeDeductionsRow.deletePermission; }
        protected getInsertPermission() { return EmployeeDeductionsRow.insertPermission; }
        protected getUpdatePermission() { return EmployeeDeductionsRow.updatePermission; }

        protected form = new EmployeeDeductionsForm(this.idPrefix);

    }
}