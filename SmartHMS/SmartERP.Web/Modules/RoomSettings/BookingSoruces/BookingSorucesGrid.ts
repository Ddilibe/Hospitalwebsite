
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class BookingSorucesGrid extends Serenity.EntityGrid<BookingSorucesRow, any> {
        protected getColumnsKey() { return BookingSorucesColumns.columnsKey; }
        protected getDialogType() { return BookingSorucesDialog; }
        protected getIdProperty() { return BookingSorucesRow.idProperty; }
        protected getInsertPermission() { return BookingSorucesRow.insertPermission; }
        protected getLocalTextPrefix() { return BookingSorucesRow.localTextPrefix; }
        protected getService() { return BookingSorucesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}