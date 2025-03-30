
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class BookingTypesGrid extends Serenity.EntityGrid<BookingTypesRow, any> {
        protected getColumnsKey() { return BookingTypesColumns.columnsKey; }
        protected getDialogType() { return BookingTypesDialog; }
        protected getIdProperty() { return BookingTypesRow.idProperty; }
        protected getInsertPermission() { return BookingTypesRow.insertPermission; }
        protected getLocalTextPrefix() { return BookingTypesRow.localTextPrefix; }
        protected getService() { return BookingTypesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}