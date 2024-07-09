using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Product
{
    public class ProductsDTO
    {
        public Int64 ProductId { get; set; }
        public Int64 ObjectId { get; set; }
        public string ProductName { get; set; }
        public string ProductDisplayName { get; set; }
        public bool IsDiscontinued { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string ProductEligibility { get; set; }
        public bool IsEligible { get; set; }
        public bool IsSFXProduct { get; set; }
        public bool IsFlashLoan { get; set; }
         public bool IsExpressLoan { get; set; }
    }
}
