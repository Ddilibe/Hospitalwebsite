
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class RoomsGrid extends Serenity.EntityGrid<RoomsRow, any> {
        protected getColumnsKey() { return RoomsColumns.columnsKey; }
        protected getDialogType() { return RoomsDialog; }
        protected getIdProperty() { return RoomsRow.idProperty; }
        protected getInsertPermission() { return RoomsRow.insertPermission; }
        protected getLocalTextPrefix() { return RoomsRow.localTextPrefix; }
        protected getService() { return RoomsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}