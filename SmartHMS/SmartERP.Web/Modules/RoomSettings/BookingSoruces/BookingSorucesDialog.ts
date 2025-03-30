
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class BookingSorucesDialog extends Serenity.EntityDialog<BookingSorucesRow, any> {
        protected getFormKey() { return BookingSorucesForm.formKey; }
        protected getIdProperty() { return BookingSorucesRow.idProperty; }
        protected getLocalTextPrefix() { return BookingSorucesRow.localTextPrefix; }
        protected getNameProperty() { return BookingSorucesRow.nameProperty; }
        protected getService() { return BookingSorucesService.baseUrl; }
        protected getDeletePermission() { return BookingSorucesRow.deletePermission; }
        protected getInsertPermission() { return BookingSorucesRow.insertPermission; }
        protected getUpdatePermission() { return BookingSorucesRow.updatePermission; }

        protected form = new BookingSorucesForm(this.idPrefix);

    }
}