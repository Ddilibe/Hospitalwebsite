
namespace SmartERP.RoomReservations {

    @Serenity.Decorators.registerClass()
    export class RoomReservationDetailsGrid extends Serenity.EntityGrid<RoomReservationDetailsRow, any> {
        protected getColumnsKey() { return RoomReservationDetailsColumns.columnsKey; }
        protected getDialogType() { return RoomReservationDetailsDialog; }
        protected getIdProperty() { return RoomReservationDetailsRow.idProperty; }
        protected getInsertPermission() { return RoomReservationDetailsRow.insertPermission; }
        protected getLocalTextPrefix() { return RoomReservationDetailsRow.localTextPrefix; }
        protected getService() { return RoomReservationDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}