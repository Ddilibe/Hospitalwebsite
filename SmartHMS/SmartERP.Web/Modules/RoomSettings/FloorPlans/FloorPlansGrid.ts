
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class FloorPlansGrid extends Serenity.EntityGrid<FloorPlansRow, any> {
        protected getColumnsKey() { return FloorPlansColumns.columnsKey; }
        protected getDialogType() { return FloorPlansDialog; }
        protected getIdProperty() { return FloorPlansRow.idProperty; }
        protected getInsertPermission() { return FloorPlansRow.insertPermission; }
        protected getLocalTextPrefix() { return FloorPlansRow.localTextPrefix; }
        protected getService() { return FloorPlansService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}