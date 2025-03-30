
namespace SmartERP.RoomFacilities {

    @Serenity.Decorators.registerClass()
    export class RoomFacilityTypesGrid extends Serenity.EntityGrid<RoomFacilityTypesRow, any> {
        protected getColumnsKey() { return RoomFacilityTypesColumns.columnsKey; }
        protected getDialogType() { return RoomFacilityTypesDialog; }
        protected getIdProperty() { return RoomFacilityTypesRow.idProperty; }
        protected getInsertPermission() { return RoomFacilityTypesRow.insertPermission; }
        protected getLocalTextPrefix() { return RoomFacilityTypesRow.localTextPrefix; }
        protected getService() { return RoomFacilityTypesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}