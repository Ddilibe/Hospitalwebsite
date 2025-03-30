using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SmartERP.RoomSettings.Forms
{
    [FormScript("RoomSettings.Complementaries")]
    [BasedOnRow(typeof(ComplementariesRow), CheckNames = true)]
    public class ComplementariesForm
    {
        public Int64 RoomType { get; set; }
        public String Complementary { get; set; }
        public Double Rate { get; set; }
    }
}