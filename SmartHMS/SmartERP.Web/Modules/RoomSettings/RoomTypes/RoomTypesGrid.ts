
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class RoomTypesGrid extends Serenity.EntityGrid<RoomTypesRow, any> {
        protected getColumnsKey() { return RoomTypesColumns.columnsKey; }
        protected getDialogType() { return RoomTypesDialog; }
        protected getIdProperty() { return RoomTypesRow.idProperty; }
        protected getInsertPermission() { return RoomTypesRow.insertPermission; }
        protected getLocalTextPrefix() { return RoomTypesRow.localTextPrefix; }
        protected getService() { return RoomTypesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}