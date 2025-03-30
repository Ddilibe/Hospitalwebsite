
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class BookingTypesDialog extends Serenity.EntityDialog<BookingTypesRow, any> {
        protected getFormKey() { return BookingTypesForm.formKey; }
        protected getIdProperty() { return BookingTypesRow.idProperty; }
        protected getLocalTextPrefix() { return BookingTypesRow.localTextPrefix; }
        protected getNameProperty() { return BookingTypesRow.nameProperty; }
        protected getService() { return BookingTypesService.baseUrl; }
        protected getDeletePermission() { return BookingTypesRow.deletePermission; }
        protected getInsertPermission() { return BookingTypesRow.insertPermission; }
        protected getUpdatePermission() { return BookingTypesRow.updatePermission; }

        protected form = new BookingTypesForm(this.idPrefix);

    }
}