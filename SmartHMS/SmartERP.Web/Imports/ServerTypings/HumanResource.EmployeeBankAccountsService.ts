namespace SmartERP.HumanResource {
    export namespace EmployeeBankAccountsService {
        export const baseUrl = 'HumanResource/EmployeeBankAccounts';

        export declare function Create(request: Serenity.SaveRequest<EmployeeBankAccountsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<EmployeeBankAccountsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<EmployeeBankAccountsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<EmployeeBankAccountsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "HumanResource/EmployeeBankAccounts/Create",
            Update = "HumanResource/EmployeeBankAccounts/Update",
            Delete = "HumanResource/EmployeeBankAccounts/Delete",
            Retrieve = "HumanResource/EmployeeBankAccounts/Retrieve",
            List = "HumanResource/EmployeeBankAccounts/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>EmployeeBankAccountsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
