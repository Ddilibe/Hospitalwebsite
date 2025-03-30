
namespace SmartERP.HumanResource {

    @Serenity.Decorators.registerClass()
    export class EmployeeBankAccountsDialog extends Serenity.EntityDialog<EmployeeBankAccountsRow, any> {
        protected getFormKey() { return EmployeeBankAccountsForm.formKey; }
        protected getIdProperty() { return EmployeeBankAccountsRow.idProperty; }
        protected getLocalTextPrefix() { return EmployeeBankAccountsRow.localTextPrefix; }
        protected getNameProperty() { return EmployeeBankAccountsRow.nameProperty; }
        protected getService() { return EmployeeBankAccountsService.baseUrl; }
        protected getDeletePermission() { return EmployeeBankAccountsRow.deletePermission; }
        protected getInsertPermission() { return EmployeeBankAccountsRow.insertPermission; }
        protected getUpdatePermission() { return EmployeeBankAccountsRow.updatePermission; }

        protected form = new EmployeeBankAccountsForm(this.idPrefix);

    }
}