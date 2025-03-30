
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class BedTypesGrid extends Serenity.EntityGrid<BedTypesRow, any> {
        protected getColumnsKey() { return BedTypesColumns.columnsKey; }
        protected getDialogType() { return BedTypesDialog; }
        protected getIdProperty() { return BedTypesRow.idProperty; }
        protected getInsertPermission() { return BedTypesRow.insertPermission; }
        protected getLocalTextPrefix() { return BedTypesRow.localTextPrefix; }
        protected getService() { return BedTypesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}