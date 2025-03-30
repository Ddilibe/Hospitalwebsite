
namespace SmartERP.RoomReservations {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class RoomReservationsDialog extends Serenity.EntityDialog<RoomReservationsRow, any> {
        protected getFormKey() { return RoomReservationsForm.formKey; }
        protected getIdProperty() { return RoomReservationsRow.idProperty; }
        protected getLocalTextPrefix() { return RoomReservationsRow.localTextPrefix; }
        protected getNameProperty() { return RoomReservationsRow.nameProperty; }
        protected getService() { return RoomReservationsService.baseUrl; }
        protected getDeletePermission() { return RoomReservationsRow.deletePermission; }
        protected getInsertPermission() { return RoomReservationsRow.insertPermission; }
        protected getUpdatePermission() { return RoomReservationsRow.updatePermission; }

        protected form = new RoomReservationsForm(this.idPrefix);

    }
}