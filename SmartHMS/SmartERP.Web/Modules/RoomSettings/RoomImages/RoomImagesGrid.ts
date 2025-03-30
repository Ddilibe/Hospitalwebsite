
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class RoomImagesGrid extends Serenity.EntityGrid<RoomImagesRow, any> {
        protected getColumnsKey() { return RoomImagesColumns.columnsKey; }
        protected getDialogType() { return RoomImagesDialog; }
        protected getIdProperty() { return RoomImagesRow.idProperty; }
        protected getInsertPermission() { return RoomImagesRow.insertPermission; }
        protected getLocalTextPrefix() { return RoomImagesRow.localTextPrefix; }
        protected getService() { return RoomImagesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}