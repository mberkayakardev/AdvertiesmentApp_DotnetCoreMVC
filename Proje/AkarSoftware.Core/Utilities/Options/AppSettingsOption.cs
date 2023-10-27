using Microsoft.EntityFrameworkCore.Query.Internal;

namespace AkarSoftware.Core.Utilities.Options
{
    // Option Pattern için uygulanacak olan alandır. 
    public class AppSettingsOption
    {
        public string DatabaseConnection { get; set; }
        public bool MainterenceMode { get; set; }


    }
}
