
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class RoomsDialog extends Serenity.EntityDialog<RoomsRow, any> {
        protected getFormKey() { return RoomsForm.formKey; }
        protected getIdProperty() { return RoomsRow.idProperty; }
        protected getLocalTextPrefix() { return RoomsRow.localTextPrefix; }
        protected getNameProperty() { return RoomsRow.nameProperty; }
        protected getService() { return RoomsService.baseUrl; }
        protected getDeletePermission() { return RoomsRow.deletePermission; }
        protected getInsertPermission() { return RoomsRow.insertPermission; }
        protected getUpdatePermission() { return RoomsRow.updatePermission; }

        protected form = new RoomsForm(this.idPrefix);

    }
}