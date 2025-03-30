
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class RoomTypesDialog extends Serenity.EntityDialog<RoomTypesRow, any> {
        protected getFormKey() { return RoomTypesForm.formKey; }
        protected getIdProperty() { return RoomTypesRow.idProperty; }
        protected getLocalTextPrefix() { return RoomTypesRow.localTextPrefix; }
        protected getNameProperty() { return RoomTypesRow.nameProperty; }
        protected getService() { return RoomTypesService.baseUrl; }
        protected getDeletePermission() { return RoomTypesRow.deletePermission; }
        protected getInsertPermission() { return RoomTypesRow.insertPermission; }
        protected getUpdatePermission() { return RoomTypesRow.updatePermission; }

        protected form = new RoomTypesForm(this.idPrefix);

    }
}