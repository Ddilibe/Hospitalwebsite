
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class RoomImagesDialog extends Serenity.EntityDialog<RoomImagesRow, any> {
        protected getFormKey() { return RoomImagesForm.formKey; }
        protected getIdProperty() { return RoomImagesRow.idProperty; }
        protected getLocalTextPrefix() { return RoomImagesRow.localTextPrefix; }
        protected getNameProperty() { return RoomImagesRow.nameProperty; }
        protected getService() { return RoomImagesService.baseUrl; }
        protected getDeletePermission() { return RoomImagesRow.deletePermission; }
        protected getInsertPermission() { return RoomImagesRow.insertPermission; }
        protected getUpdatePermission() { return RoomImagesRow.updatePermission; }

        protected form = new RoomImagesForm(this.idPrefix);

    }
}