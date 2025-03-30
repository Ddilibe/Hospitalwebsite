
namespace SmartERP.HumanResource {

    @Serenity.Decorators.registerClass()
    export class EmployeeBankAccountsGrid extends Serenity.EntityGrid<EmployeeBankAccountsRow, any> {
        protected getColumnsKey() { return 'HumanResource.EmployeeBankAccounts'; }
        protected getDialogType() { return EmployeeBankAccountsDialog; }
        protected getIdProperty() { return EmployeeBankAccountsRow.idProperty; }
        protected getInsertPermission() { return EmployeeBankAccountsRow.insertPermission; }
        protected getLocalTextPrefix() { return EmployeeBankAccountsRow.localTextPrefix; }
        protected getService() { return EmployeeBankAccountsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}