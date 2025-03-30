
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class FloorPlansDialog extends Serenity.EntityDialog<FloorPlansRow, any> {
        protected getFormKey() { return FloorPlansForm.formKey; }
        protected getIdProperty() { return FloorPlansRow.idProperty; }
        protected getLocalTextPrefix() { return FloorPlansRow.localTextPrefix; }
        protected getService() { return FloorPlansService.baseUrl; }
        protected getDeletePermission() { return FloorPlansRow.deletePermission; }
        protected getInsertPermission() { return FloorPlansRow.insertPermission; }
        protected getUpdatePermission() { return FloorPlansRow.updatePermission; }

        protected form = new FloorPlansForm(this.idPrefix);

    }
}