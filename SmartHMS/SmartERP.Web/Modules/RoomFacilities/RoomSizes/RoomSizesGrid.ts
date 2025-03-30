
namespace SmartERP.RoomFacilities {

    @Serenity.Decorators.registerClass()
    export class RoomSizesGrid extends Serenity.EntityGrid<RoomSizesRow, any> {
        protected getColumnsKey() { return RoomSizesColumns.columnsKey; }
        protected getDialogType() { return RoomSizesDialog; }
        protected getIdProperty() { return RoomSizesRow.idProperty; }
        protected getInsertPermission() { return RoomSizesRow.insertPermission; }
        protected getLocalTextPrefix() { return RoomSizesRow.localTextPrefix; }
        protected getService() { return RoomSizesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}