
namespace SmartERP.HumanResource {

    @Serenity.Decorators.registerClass()
    export class EmployeeDeductionsGrid extends Serenity.EntityGrid<EmployeeDeductionsRow, any> {
        protected getColumnsKey() { return EmployeeDeductionsColumns.columnsKey; }
        protected getDialogType() { return EmployeeDeductionsDialog; }
        protected getIdProperty() { return EmployeeDeductionsRow.idProperty; }
        protected getInsertPermission() { return EmployeeDeductionsRow.insertPermission; }
        protected getLocalTextPrefix() { return EmployeeDeductionsRow.localTextPrefix; }
        protected getService() { return EmployeeDeductionsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}