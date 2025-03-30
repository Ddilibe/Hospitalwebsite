
namespace SmartERP.Masters {

    @Serenity.Decorators.registerClass()
    export class IncomesDialog extends Serenity.EntityDialog<IncomesRow, any> {
        protected getFormKey() { return IncomesForm.formKey; }
        protected getIdProperty() { return IncomesRow.idProperty; }
        protected getLocalTextPrefix() { return IncomesRow.localTextPrefix; }
        protected getNameProperty() { return IncomesRow.nameProperty; }
        protected getService() { return IncomesService.baseUrl; }
        protected getDeletePermission() { return IncomesRow.deletePermission; }
        protected getInsertPermission() { return IncomesRow.insertPermission; }
        protected getUpdatePermission() { return IncomesRow.updatePermission; }

        protected form = new IncomesForm(this.idPrefix);

    }
}