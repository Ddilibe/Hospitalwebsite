using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SmartERP.RoomSettings.ComplementariesRow;

namespace SmartERP.RoomSettings
{
    public interface IComplementariesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ComplementariesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IComplementariesDeleteHandler
    {
        public ComplementariesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}