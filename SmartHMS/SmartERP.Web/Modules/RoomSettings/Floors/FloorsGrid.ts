
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class FloorsGrid extends Serenity.EntityGrid<FloorsRow, any> {
        protected getColumnsKey() { return FloorsColumns.columnsKey; }
        protected getDialogType() { return FloorsDialog; }
        protected getIdProperty() { return FloorsRow.idProperty; }
        protected getInsertPermission() { return FloorsRow.insertPermission; }
        protected getLocalTextPrefix() { return FloorsRow.localTextPrefix; }
        protected getService() { return FloorsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}