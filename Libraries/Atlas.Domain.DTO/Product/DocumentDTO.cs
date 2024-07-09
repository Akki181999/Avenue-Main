using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Product
{
   public class DocumentDTO
    {
        public long DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DisplayDocumentName { get; set; }
        public string DocumentType { get; set; }
        public string UploadPath { get; set; }
        public long Size { get; set; }
        //public bool IsMandatory { get; set; }
    }
}
