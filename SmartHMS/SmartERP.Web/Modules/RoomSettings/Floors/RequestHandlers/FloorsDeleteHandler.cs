using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomSettings.FloorsRow;

namespace SmartERP.RoomSettings
{
    public interface IFloorsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class FloorsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IFloorsDeleteHandler
    {
        public FloorsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}