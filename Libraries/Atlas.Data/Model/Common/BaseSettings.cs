using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Common
{
    public class BaseSettings
    {
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public bool IsActive { get; set; }
        public string ProjectName { get; set; }
        public string ServerIPAddress { get; set; }
    }

    public class ProjectDetails
    {
        public string ProjectName { get; set; }
        public string CacheKeyName { get; set; }
    }

}
