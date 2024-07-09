using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Config
{
    public class FolderPath
    {
        public string contentFolderPath { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string domain { get; set; }
        public bool useNetworkCredentials { get; set; }
        public string UseEnhanced_ViewQuotation { get; set; }
    }
}
