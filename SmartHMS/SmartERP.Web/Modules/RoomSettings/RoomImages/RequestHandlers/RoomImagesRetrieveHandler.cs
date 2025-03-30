using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SmartERP.RoomSettings.RoomImagesRow>;
using MyRow = SmartERP.RoomSettings.RoomImagesRow;

namespace SmartERP.RoomSettings
{
    public interface IRoomImagesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RoomImagesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoomImagesRetrieveHandler
    {
        public RoomImagesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}