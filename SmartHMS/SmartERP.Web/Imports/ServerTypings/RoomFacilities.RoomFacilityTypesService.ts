namespace SmartERP.RoomFacilities {
    export namespace RoomFacilityTypesService {
        export const baseUrl = 'RoomFacilities/RoomFacilityTypes';

        export declare function Create(request: Serenity.SaveRequest<RoomFacilityTypesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<RoomFacilityTypesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<RoomFacilityTypesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<RoomFacilityTypesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "RoomFacilities/RoomFacilityTypes/Create",
            Update = "RoomFacilities/RoomFacilityTypes/Update",
            Delete = "RoomFacilities/RoomFacilityTypes/Delete",
            Retrieve = "RoomFacilities/RoomFacilityTypes/Retrieve",
            List = "RoomFacilities/RoomFacilityTypes/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>RoomFacilityTypesService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
