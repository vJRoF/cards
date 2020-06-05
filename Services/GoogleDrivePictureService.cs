using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_vue_app.Services
{
    public class GoogleDrivePictureService : IPictureService
    {
        private string _pathPattern = "https://drive.google.com/uc?export=view&id=1X1ChJjhZkvnBGP4De8Gf5MnsHleaT6Qy";

        public byte GetPicture()
        {
            throw new NotImplementedException();
        }
    }
}
