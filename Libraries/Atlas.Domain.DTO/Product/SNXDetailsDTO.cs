using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Product
{
    public class SNXDetailsDTO
    {
        public string SNXName { get; set; }
        public string SNXPath { get; set; }
        public string FolderName { get; set; }
        public string FileName { get; set; }
        public string DocumentCopyType { get; set; }
    }

    public class SNXPDFDetailsDTO
    {
        public string MergedFolderName { get; set; }
        public string MergedFileName { get; set; }
        public List<SNXDetailsDTO> snxdetails { get; set; }
    }
}
