using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SmartERP.RoomSettings.ComplementariesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SmartERP.RoomSettings.ComplementariesRow;

namespace SmartERP.RoomSettings
{
    public interface IComplementariesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ComplementariesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IComplementariesSaveHandler
    {
        public ComplementariesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}