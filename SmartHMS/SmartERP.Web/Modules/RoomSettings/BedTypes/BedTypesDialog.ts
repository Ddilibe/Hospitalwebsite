
namespace SmartERP.RoomSettings {

    @Serenity.Decorators.registerClass()
    export class BedTypesDialog extends Serenity.EntityDialog<BedTypesRow, any> {
        protected getFormKey() { return BedTypesForm.formKey; }
        protected getIdProperty() { return BedTypesRow.idProperty; }
        protected getLocalTextPrefix() { return BedTypesRow.localTextPrefix; }
        protected getNameProperty() { return BedTypesRow.nameProperty; }
        protected getService() { return BedTypesService.baseUrl; }
        protected getDeletePermission() { return BedTypesRow.deletePermission; }
        protected getInsertPermission() { return BedTypesRow.insertPermission; }
        protected getUpdatePermission() { return BedTypesRow.updatePermission; }

        protected form = new BedTypesForm(this.idPrefix);

    }
}