
namespace SmartERP.RoomReservations {

    @Serenity.Decorators.registerClass()
    export class RoomReservationsGrid extends Serenity.EntityGrid<RoomReservationsRow, any> {
        protected getColumnsKey() { return RoomReservationsColumns.columnsKey; }
        protected getDialogType() { return RoomReservationsDialog; }
        protected getIdProperty() { return RoomReservationsRow.idProperty; }
        protected getInsertPermission() { return RoomReservationsRow.insertPermission; }
        protected getLocalTextPrefix() { return RoomReservationsRow.localTextPrefix; }
        protected getService() { return RoomReservationsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}