using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.DataAccess
{
    class Utils
    {
        public static Uri MakeGoogleDriveExportUri(string imageId)
        {
            return new Uri($"https://drive.google.com/uc?export=view&id={imageId}");
        }
    }
}
