using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Forms
{
    [FormScript("RoomSettings.RoomImages")]
    [BasedOnRow(typeof(RoomImagesRow), CheckNames = true)]
    public class RoomImagesForm
    {
        public Int64 RoomType { get; set; }
        public String Image { get; set; }
    }
}