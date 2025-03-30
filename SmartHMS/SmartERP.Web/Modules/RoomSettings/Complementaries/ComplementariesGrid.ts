
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class ComplementariesGrid extends Serenity.EntityGrid<ComplementariesRow, any> {
        protected getColumnsKey() { return ComplementariesColumns.columnsKey; }
        protected getDialogType() { return ComplementariesDialog; }
        protected getIdProperty() { return ComplementariesRow.idProperty; }
        protected getInsertPermission() { return ComplementariesRow.insertPermission; }
        protected getLocalTextPrefix() { return ComplementariesRow.localTextPrefix; }
        protected getService() { return ComplementariesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}