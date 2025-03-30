using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomSettings.ComplementariesRow>;
using MyRow = SmartERP.RoomSettings.ComplementariesRow;

namespace SmartERP.RoomSettings
{
    public interface IComplementariesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ComplementariesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IComplementariesListHandler
    {
        public ComplementariesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}