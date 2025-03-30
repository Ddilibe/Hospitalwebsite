using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomSettings.BedTypesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomSettings.BedTypesRow;

namespace SmartERP.RoomSettings
{
    public interface IBedTypesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BedTypesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBedTypesSaveHandler
    {
        public BedTypesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}