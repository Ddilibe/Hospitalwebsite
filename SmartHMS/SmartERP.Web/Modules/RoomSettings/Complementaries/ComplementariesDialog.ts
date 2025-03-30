
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class ComplementariesDialog extends Serenity.EntityDialog<ComplementariesRow, any> {
        protected getFormKey() { return ComplementariesForm.formKey; }
        protected getIdProperty() { return ComplementariesRow.idProperty; }
        protected getLocalTextPrefix() { return ComplementariesRow.localTextPrefix; }
        protected getNameProperty() { return ComplementariesRow.nameProperty; }
        protected getService() { return ComplementariesService.baseUrl; }
        protected getDeletePermission() { return ComplementariesRow.deletePermission; }
        protected getInsertPermission() { return ComplementariesRow.insertPermission; }
        protected getUpdatePermission() { return ComplementariesRow.updatePermission; }

        protected form = new ComplementariesForm(this.idPrefix);

    }
}