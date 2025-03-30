
namespace SmartERP.RoomFacilities {

    @Serenity.Decorators.registerClass()
    export class RoomFacilitiesDialog extends Serenity.EntityDialog<RoomFacilitiesRow, any> {
        protected getFormKey() { return RoomFacilitiesForm.formKey; }
        protected getIdProperty() { return RoomFacilitiesRow.idProperty; }
        protected getLocalTextPrefix() { return RoomFacilitiesRow.localTextPrefix; }
        protected getNameProperty() { return RoomFacilitiesRow.nameProperty; }
        protected getService() { return RoomFacilitiesService.baseUrl; }
        protected getDeletePermission() { return RoomFacilitiesRow.deletePermission; }
        protected getInsertPermission() { return RoomFacilitiesRow.insertPermission; }
        protected getUpdatePermission() { return RoomFacilitiesRow.updatePermission; }

        protected form = new RoomFacilitiesForm(this.idPrefix);

    }
}