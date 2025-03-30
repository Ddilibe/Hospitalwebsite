
namespace SmartERP.RoomFacilities {

    @Serenity.Decorators.registerClass()
    export class RoomFacilityTypesDialog extends Serenity.EntityDialog<RoomFacilityTypesRow, any> {
        protected getFormKey() { return RoomFacilityTypesForm.formKey; }
        protected getIdProperty() { return RoomFacilityTypesRow.idProperty; }
        protected getLocalTextPrefix() { return RoomFacilityTypesRow.localTextPrefix; }
        protected getNameProperty() { return RoomFacilityTypesRow.nameProperty; }
        protected getService() { return RoomFacilityTypesService.baseUrl; }
        protected getDeletePermission() { return RoomFacilityTypesRow.deletePermission; }
        protected getInsertPermission() { return RoomFacilityTypesRow.insertPermission; }
        protected getUpdatePermission() { return RoomFacilityTypesRow.updatePermission; }

        protected form = new RoomFacilityTypesForm(this.idPrefix);

    }
}