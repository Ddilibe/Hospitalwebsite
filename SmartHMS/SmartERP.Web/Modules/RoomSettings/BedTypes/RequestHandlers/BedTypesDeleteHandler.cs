using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomSettings.BedTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IBedTypesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class BedTypesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBedTypesDeleteHandler
    {
        public BedTypesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}