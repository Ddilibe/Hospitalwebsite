
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class FloorsDialog extends Serenity.EntityDialog<FloorsRow, any> {
        protected getFormKey() { return FloorsForm.formKey; }
        protected getIdProperty() { return FloorsRow.idProperty; }
        protected getLocalTextPrefix() { return FloorsRow.localTextPrefix; }
        protected getNameProperty() { return FloorsRow.nameProperty; }
        protected getService() { return FloorsService.baseUrl; }
        protected getDeletePermission() { return FloorsRow.deletePermission; }
        protected getInsertPermission() { return FloorsRow.insertPermission; }
        protected getUpdatePermission() { return FloorsRow.updatePermission; }

        protected form = new FloorsForm(this.idPrefix);

    }
}