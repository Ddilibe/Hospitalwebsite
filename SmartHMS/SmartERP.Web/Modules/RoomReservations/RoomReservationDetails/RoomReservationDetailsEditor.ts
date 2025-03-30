
namespace SmartERP.RoomReservations {

    @Serenity.Decorators.registerClass()
    export class RoomReservationDetailsEditor extends Serenity.Extensions.GridEditorBase<RoomReservationDetailsRow> {
        protected getColumnsKey() { return RoomReservationDetailsColumns.columnsKey; }
        protected getDialogType() { return RoomReservationDetailsDialog; }
        protected getLocalTextPrefix() { return RoomReservationDetailsRow.localTextPrefix; }


        constructor(container: JQuery) {
            super(container);
        }


        protected validateEntity(row: RoomReservationDetailsRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            //row.ProductName = Merchandise.ProductRow.getLookup()
            //    .itemById[row.ProductId].Name;

            return true;
        }


    }



}