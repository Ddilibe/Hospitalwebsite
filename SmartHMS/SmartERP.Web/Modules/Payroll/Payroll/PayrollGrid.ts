
namespace SmartERP.Payroll {

    @Serenity.Decorators.registerClass()
    export class PayrollGrid extends Serenity.EntityGrid<PayrollRow, any> {
        protected getColumnsKey() { return PayrollColumns.columnsKey; }
        protected getDialogType() { return PayrollDialog; }
        protected getIdProperty() { return PayrollRow.idProperty; }
        protected getInsertPermission() { return PayrollRow.insertPermission; }
        protected getLocalTextPrefix() { return PayrollRow.localTextPrefix; }
        protected getService() { return PayrollService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}