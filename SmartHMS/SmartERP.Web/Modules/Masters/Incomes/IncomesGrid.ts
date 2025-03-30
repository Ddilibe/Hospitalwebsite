
namespace SmartERP.Masters {

    @Serenity.Decorators.registerClass()
    export class IncomesGrid extends Serenity.EntityGrid<IncomesRow, any> {
        protected getColumnsKey() { return IncomesColumns.columnsKey; }
        protected getDialogType() { return IncomesDialog; }
        protected getIdProperty() { return IncomesRow.idProperty; }
        protected getInsertPermission() { return IncomesRow.insertPermission; }
        protected getLocalTextPrefix() { return IncomesRow.localTextPrefix; }
        protected getService() { return IncomesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}