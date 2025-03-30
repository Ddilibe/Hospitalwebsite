namespace SmartERP.RoomFacilities {
    export namespace RoomFacilitiesService {
        export const baseUrl = 'RoomFacilities/RoomFacilities';

        export declare function Create(request: Serenity.SaveRequest<RoomFacilitiesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<RoomFacilitiesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RoomFacilitiesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RoomFacilitiesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "RoomFacilities/RoomFacilities/Create",
            Update = "RoomFacilities/RoomFacilities/Update",
            Delete = "RoomFacilities/RoomFacilities/Delete",
            Retrieve = "RoomFacilities/RoomFacilities/Retrieve",
            List = "RoomFacilities/RoomFacilities/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>RoomFacilitiesService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
