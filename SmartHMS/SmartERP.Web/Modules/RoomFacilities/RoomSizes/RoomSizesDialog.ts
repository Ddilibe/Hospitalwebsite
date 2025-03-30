
namespace SmartERP.RoomFacilities {

    @Serenity.Decorators.registerClass()
    export class RoomSizesDialog extends Serenity.EntityDialog<RoomSizesRow, any> {
        protected getFormKey() { return RoomSizesForm.formKey; }
        protected getIdProperty() { return RoomSizesRow.idProperty; }
        protected getLocalTextPrefix() { return RoomSizesRow.localTextPrefix; }
        protected getNameProperty() { return RoomSizesRow.nameProperty; }
        protected getService() { return RoomSizesService.baseUrl; }
        protected getDeletePermission() { return RoomSizesRow.deletePermission; }
        protected getInsertPermission() { return RoomSizesRow.insertPermission; }
        protected getUpdatePermission() { return RoomSizesRow.updatePermission; }

        protected form = new RoomSizesForm(this.idPrefix);

    }
}