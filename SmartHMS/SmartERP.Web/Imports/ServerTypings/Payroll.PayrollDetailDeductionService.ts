namespace SmartERP.Payroll {
    export namespace PayrollDetailDeductionService {
        export const baseUrl = 'Payroll/PayrollDetailDeduction';

        export declare function Create(request: Serenity.SaveRequest<PayrollDetailDeductionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<PayrollDetailDeductionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PayrollDetailDeductionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PayrollDetailDeductionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Payroll/PayrollDetailDeduction/Create",
            Update = "Payroll/PayrollDetailDeduction/Update",
            Delete = "Payroll/PayrollDetailDeduction/Delete",
            Retrieve = "Payroll/PayrollDetailDeduction/Retrieve",
            List = "Payroll/PayrollDetailDeduction/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>PayrollDetailDeductionService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
