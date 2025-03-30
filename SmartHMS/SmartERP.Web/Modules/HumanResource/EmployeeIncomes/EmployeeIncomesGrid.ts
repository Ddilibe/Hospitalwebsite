
namespace SmartERP.HumanResource {

    @Serenity.Decorators.registerClass()
    export class EmployeeIncomesGrid extends Serenity.EntityGrid<EmployeeIncomesRow, any> {
        protected getColumnsKey() { return EmployeeIncomesColumns.columnsKey; }
        protected getDialogType() { return EmployeeIncomesDialog; }
        protected getIdProperty() { return EmployeeIncomesRow.idProperty; }
        protected getInsertPermission() { return EmployeeIncomesRow.insertPermission; }
        protected getLocalTextPrefix() { return EmployeeIncomesRow.localTextPrefix; }
        protected getService() { return EmployeeIncomesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}