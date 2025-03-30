
namespace SmartERP.RoomReservations {

    @Serenity.Decorators.registerClass()
    export class RoomReservationDetailsDialog extends Serenity.EntityDialog<RoomReservationDetailsRow, any> {
        protected getFormKey() { return RoomReservationDetailsForm.formKey; }
        protected getIdProperty() { return RoomReservationDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return RoomReservationDetailsRow.localTextPrefix; }
        protected getService() { return RoomReservationDetailsService.baseUrl; }
        protected getDeletePermission() { return RoomReservationDetailsRow.deletePermission; }
        protected getInsertPermission() { return RoomReservationDetailsRow.insertPermission; }
        protected getUpdatePermission() { return RoomReservationDetailsRow.updatePermission; }

        protected form = new RoomReservationDetailsForm(this.idPrefix);

    }
}