using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SmartERP.RoomSettings.FloorsRow>;
using MyRow = SmartERP.RoomSettings.FloorsRow;

namespace SmartERP.RoomSettings
{
    public interface IFloorsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class FloorsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IFloorsListHandler
    {
        public FloorsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}