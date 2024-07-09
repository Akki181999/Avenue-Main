using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.QR
{
   public class QRDetailsDTO
    {
        public Int64 QRId { get; set; }
        public Int64 ApplicationId { get; set; }
        public Int64 ClientId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public String Request { get; set; }
        public String Response { get; set; }
        public String FileName { get; set; }
        public String QRType { get; set; }
        public String DocumentName { get; set; }
    }
}
