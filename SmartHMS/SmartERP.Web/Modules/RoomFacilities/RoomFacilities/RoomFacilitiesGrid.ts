
namespace SmartERP.RoomFacilities {

    @Serenity.Decorators.registerClass()
    export class RoomFacilitiesGrid extends Serenity.EntityGrid<RoomFacilitiesRow, any> {
        protected getColumnsKey() { return RoomFacilitiesColumns.columnsKey; }
        protected getDialogType() { return RoomFacilitiesDialog; }
        protected getIdProperty() { return RoomFacilitiesRow.idProperty; }
        protected getInsertPermission() { return RoomFacilitiesRow.insertPermission; }
        protected getLocalTextPrefix() { return RoomFacilitiesRow.localTextPrefix; }
        protected getService() { return RoomFacilitiesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}