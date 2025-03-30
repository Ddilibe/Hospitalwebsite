using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomSettings.BedTypesRow>;
using MyRow = SmartERP.RoomSettings.BedTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IBedTypesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BedTypesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBedTypesListHandler
    {
        public BedTypesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}